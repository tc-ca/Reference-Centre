using MTCO.InspectionMobileApp.BLL.Local.Contracts.Reference;
using MTCO.InspectionMobileApp.Local.DTO;
using MTCO.InspectionMobileApp.ReferenceCentre.Common;
using MTCO.InspectionMobileApp.ReferenceCentre.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MTCO.InspectionMobileApp.ReferenceCentre.ViewModels
{
    public class ReferenceCentreViewModel : BindableBase, INavigationAware
    {
        IReferenceService _referenceService;
        private enum CurrentActionType { OTHER, SEARCH, FOLDER, FILE, MENU };
        private readonly IEventAggregator _eventAggregator;
        private static string rootFolderPath = ConfigurationManager.AppSettings["OfflineDrivePath"].ToString();
        
        private string _SelectedTemplate;
        public string SelectedTemplate
        {
            get { return _SelectedTemplate; }
            set { SetProperty(ref _SelectedTemplate, value); }
        }

        private bool _isCheckIoBusy;
        public bool IsCheckIOBusy
        {
            get
            {
                return _isCheckIoBusy;
            }
            set
            {
                SetProperty(ref _isCheckIoBusy, value);
                if (value)
                {
                    Mouse.OverrideCursor = Cursors.Wait;
                }
                else
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }

        }

        private bool isFileInFavorites;
        public bool IsFileInFavorites
        {
            get { return isFileInFavorites; }
            set { SetProperty(ref isFileInFavorites, value); }
        }

        private bool isFavoriteView;
        public bool IsFavoriteView
        {
            get { return isFavoriteView; }
            set { SetProperty(ref isFavoriteView, value); }
        }

        private TCFile rightPanelItem;
        public TCFile RightPanelItem
        {
            get { return rightPanelItem; }
            set { SetProperty(ref rightPanelItem, value); }
        }

        private bool isRightPanelVisible;
        public bool IsRightPanelVisible
        {
            get { return isRightPanelVisible; }
            set { SetProperty(ref isRightPanelVisible, value);}
        }

        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { SetProperty(ref fileSize, value); }
        }

        private string pathText;
        public string PathText
        {
            get { return pathText; }
            set { SetProperty(ref pathText, value); }
        }

        private string dateModifiedText;
        public string DateModifiedText
        {
            get { return dateModifiedText; }
            set { SetProperty(ref dateModifiedText, value); }
        }

        private string sizeText;
        public string SizeText
        {
            get { return sizeText; }
            set { SetProperty(ref sizeText, value); }
        }

        private string dateCreatedText;
        public string DateCreatedText
        {
            get { return dateCreatedText; }
            set { SetProperty(ref dateCreatedText, value); }
        }

        private string titleText;
        public string Title
        {
            get { return titleText; }
            set { SetProperty(ref titleText, value); }
        }

        private TCFile selectedFile;
        public TCFile SelectedFile
        {
            get { return selectedFile; }
            set { SetProperty(ref selectedFile, value); }
        }
        private string iconPath;
        public string IconPath
        {
            get { return iconPath; }
            set { SetProperty(ref iconPath, value); }
        }

        //private ImageSource fileIcon;
        //public ImageSource FileIcon
        //{
        //    get { return fileIcon; }
        //    set { SetProperty(ref fileIcon, value); }
        //}

        private DirectoryInfo rootFolder;
        public ObservableCollection<TCFile> FileCollection { get; set; }

        public ObservableCollection<TCFile> FolderMenu { get; set; }

        private string currentFolder;
        private string previousFolder;

        private string searchFolder;
        private string previousFolderBeforeSearch;

        private ImageSource folderIcon;

        private string searchTerm;
        public string SearchTerm {
            get
            {
                return searchTerm;
            }
            set
            {
                SetProperty(ref searchTerm, value);
                if (string.IsNullOrEmpty(searchTerm))
                {
                    if (isSearchInActive)
                    {
                        ClearSearch();
                    }
                    else if (IsFavoriteView)
                    {
                        FavoritesLoader();
                    }
                }
            }
        }

        private void ClearSearch()
        {
            lastSearchTerm = string.Empty;
            isSearchInActive = false;
            ClearMenu();
            currentFolder = searchFolder;
            previousFolder = previousFolderBeforeSearch;
            LoadData();
        }

        private string lastSearchTerm;

        private bool isSearchInActive;

        //private string favoriteTitle;
        //public string FavoriteTitle
        //{
        //    get { return favoriteTitle; }
        //    set { SetProperty(ref favoriteTitle, value);}
        //}
        public ICommand CopyPathCommand
        {
            get
            {
                return new DelegateCommand(CopyPath);
            }
        }

        private void CopyPath()
        {
            try
            {
                Clipboard.SetText(SelectedFile.FilePath);
            }
            catch (Exception)
            {
            }
        }

        public ICommand CloseInfoPanelCommand
        {
            get
            {
                return new DelegateCommand(CloseInfoPanel);
            }
        }

        private void CloseInfoPanel()
        {
            if(SelectedFile != null)
                SelectedFile.IsInfoMenuOpen = false;
            IsRightPanelVisible = false;
        }

        public ICommand ShowFavoritesCommand
        {
            get
            {
                return new DelegateCommand(ShowFavorites);
            }
        }

        public ICommand OpenFileCommand
        {
            get
            {
                return new DelegateCommand(OpenFile);
            }
        }

        public ICommand OpenFavCommand
        {
            get
            {
                return new DelegateCommand(HandleInfoPanelFavoriteClick);
            }
        }


        public ICommand SearchCommand
        {
            get
            {
                return new DelegateCommand(Search);
            }
        }

        public void OpenFile()
        {
            try
            {
                IsCheckIOBusy = true;
                System.Diagnostics.Process.Start(SelectedFile.File.FullName);
                IsCheckIOBusy = false;
            }
            catch (Exception)
            {
                var errorTitle = Properties.Resource.errorMsgUnautorizedAccessTitle;
                var errorMessage = Properties.Resource.errorMsgUnautorizedAccessMessage;
                MessageBox.Show(errorMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Warning);
                IsCheckIOBusy = false;
            }
        }

        public void HandleInfoPanelFavoriteClick()
        {
            AddRemoveFavorite(rightPanelItem);
        }

        public void AddRemoveFavorite(TCFile selection)
        {
            if (selectedFile != null)
            {
                if (_referenceService.IsFileInFavorite(selection.FilePath))
                {
                    _referenceService.RemoveFromFavourites(selection.FilePath);
                    SelectedFile.IsFavorited = false;
                }
                else
                {
                    cc310_reference_centre_file file = new cc310_reference_centre_file();
                    file.file_nm = selection.FileNameText;

                    file.file_full_nm = selection.FilePath;
                    //file.file_size_nbr = selection.File.Length; //Do we really need this?
                    file.file_path_txt = selection.FilePath;
                    _referenceService.AddToFavourites(file);

                    selection.IsFavorited = true;
                }

                UpdateFavoriteTitle(selection);
                
                if (isFavoriteView)
                {
                    FavoritesLoader();
                }
            }
        }

        private void FavoritesLoader()
        {
            var favoriteList = _referenceService.GetAllFavouriteFiles();
            RenderFavorites(favoriteList);
            IsRightPanelVisible = false;
        }
        
        private void ShowFavorites()
        {
            IsFavoriteView = !IsFavoriteView;
            if(isSearchInActive && !isFavoriteView)
            {
                Search();
            }
            else
            {
                LoadData();
            }
        }

        public ReferenceCentreViewModel(IEventAggregator eventAggregator, IReferenceService referenceService)
        {
            isSearchInActive = false;
            SelectedTemplate = "IconViewTemplate";
            var templateResources = Application.Current.Resources[typeof(DataTemplate)];
            //var selectedTemp = templateResources["IconViewTemplate"];
                //FindResource("PersonDataTemplate") as DataTemplate;
            IsFavoriteView = false;
            folderIcon = GetFolderImage();
            _referenceService = referenceService;
            _eventAggregator = eventAggregator;
            FileCollection = new ObservableCollection<TCFile>();
            FolderMenu = new ObservableCollection<TCFile>();
            currentFolder = rootFolderPath;
            rootFolder = new DirectoryInfo(rootFolderPath);
            LoadData();
        }

        public void ClearMenu()
        {
            FolderMenu.Clear();
        }

        public void Search()
        {
            try
            {
                if (!string.IsNullOrEmpty(SearchTerm))
                {
                    IsCheckIOBusy = true;
                    FileCollection.Clear();

                    IsRightPanelVisible = false;
                    if (!isFavoriteView)
                    {
                        IsFavoriteView = false;
                        if (!isSearchInActive)
                        {
                            searchFolder = currentFolder;
                            previousFolderBeforeSearch = previousFolder;
                        }

                        if (lastSearchTerm != searchTerm)
                        {
                            lastSearchTerm = searchTerm;
                            ClearMenu();

                            var clearSearchName = Properties.Resource.lblClearSearchResults;
                            var clearSearchMenu = new TCFile(clearSearchName, searchFolder, previousFolderBeforeSearch, TCFile.TCType.CLEAR, null);
                            clearSearchMenu.FileClickedEvent += MenuItem_FileClickedEvent;
                            FolderMenu.Add(clearSearchMenu);

                            var searchItemName = Properties.Resource.lblSearchResults;
                            var searchResultsMenu = new TCFile(searchItemName, searchFolder, previousFolderBeforeSearch, TCFile.TCType.SEARCH, null);
                            searchResultsMenu.FileClickedEvent += MenuItem_FileClickedEvent;
                            FolderMenu.Add(searchResultsMenu);
                        }
                        
                        try
                        {
                            List<FileInfo> searchResults = new List<FileInfo>();
                            var fileSearchStringResults = SafeFileEnumerator.EnumerateFiles(searchFolder, $"*{SearchTerm}*", SearchOption.AllDirectories);
                            foreach (var filePath in fileSearchStringResults)
                            {
                                FileInfo fileToAdd = new FileInfo(filePath);
                                searchResults.Add(fileToAdd);
                            }
                            isSearchInActive = true;
                            RenderFilesInView(searchResults, true);
                        }
                        catch (UnauthorizedAccessException ue)
                        {
                            Console.WriteLine(ue.Message);
                        }
                        catch(FileNotFoundException fnfe)
                        {
                            Console.WriteLine(fnfe.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        try
                        {
                            List<DirectoryInfo> searchDirResults = new List<DirectoryInfo>();
                            var fileSearchStringResults = SafeFileEnumerator.EnumerateDirectories(searchFolder, $"*{SearchTerm}*", SearchOption.AllDirectories);
                            foreach (var filePath in fileSearchStringResults)
                            {
                                DirectoryInfo fileToAdd = new DirectoryInfo(filePath);
                                searchDirResults.Add(fileToAdd);
                            }
                            RenderDirectoriesInView(searchDirResults);
                        }
                        catch (UnauthorizedAccessException ue)
                        {
                            Console.WriteLine(ue.Message);
                        }
                        catch (DirectoryNotFoundException dnfe)
                        {
                            Console.WriteLine(dnfe.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        var searchResults = _referenceService.SearchFavorite(SearchTerm);
                        RenderFavorites(searchResults);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Search failed: {0}", e.ToString());
            }
        }

        private void RenderDirectoriesInView(List<DirectoryInfo> directories)
        {
            try
            {
                foreach (var dir in directories)
                {
                    TCFile file = new TCFile(dir.Name,dir.FullName, previousFolder, TCFile.TCType.FOLDER, IconUtilities.FolderIcon);
                    file.FileClickedEvent += File_FileClickedEvent;
                    file.FavouriteClickEvent += File_FavouriteClickEvent;
                    FileCollection.Add(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Render Folders In View Failed: {0}", e.ToString());
            }
            
        }

        private void RenderFilesInView(List<FileInfo> files, bool isSearchResults)
        {
            try
            {
                IsCheckIOBusy = true;
                IsRightPanelVisible = false;
                foreach (var mFile in files)
                {
                    //Get Icons
                    string shortCutPath = mFile.FullName;
                    string icon = IconUtilities.GetIconString(shortCutPath);
                    //ImageSource image = null;
                    //string extension = IconUtilities.GetExtension(shortCutPath);
                    //try
                    //{
                    //    if (extension == ".lnk")
                    //    {
                    //        image = IconUtilities.GetIconForShortCut(shortCutPath);
                    //    }
                    //    else
                    //    {
                    //        image = IconUtilities.GetIcon(shortCutPath);
                    //    }
                    //    if (image == null)
                    //    {
                    //        image = folderIcon;
                    //    }
                    //}
                    //catch (Exception)
                    //{
                    //    image = folderIcon;
                    //}
                    var isFavorite = _referenceService.IsFileInFavorite(mFile.FullName);
                    TCFile file = new TCFile(mFile.Name, mFile.FullName, previousFolder, TCFile.TCType.FILE, icon);
                    file.IsFavorited = isFavorite;
                    file.DoubleClickEvent += File_DoubleClickEvent;
                    file.FileClickedEvent += File_FileClickedEvent;
                    file.InfoPanelClickEvent += File_InfoPanelClickEvent;
                    file.FavouriteClickEvent += File_FavouriteClickEvent;
                    FileCollection.Add(file);
                }
                IsCheckIOBusy = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Render Files In View Failed: {0}", e.ToString());
            }
        }

        private void File_FavouriteClickEvent(object sender, FileClickedEventArgs args)
        {
            var newSelection = sender as TCFile;

            UpdateInfoPanelVisibility(newSelection);

            SelectedFile = newSelection;
            AddRemoveFavorite(newSelection);
            //RenderRightPanel(newSelection);

            if (SelectedFile != null)
                SelectedFile.IsInfoMenuOpen = IsRightPanelVisible;
        }

        private void File_InfoPanelClickEvent(object sender, FileClickedEventArgs args)
        {
            var newSelection = sender as TCFile;

            UpdateInfoPanelVisibility(newSelection);

            SelectedFile = newSelection;
            if (SelectedFile.IsInfoMenuOpen)
            {
                RenderRightPanel();
            }
            IsRightPanelVisible = SelectedFile.IsInfoMenuOpen;
        }

        private void UpdateInfoPanelVisibility(TCFile newSelection)
        {
            if (SelectedFile != null && newSelection != null && (selectedFile.FilePath != newSelection.FilePath))
            {
                SelectedFile.IsInfoMenuOpen = false;
            }
        }

        private void RenderFavorites(ObservableCollection<cc310_reference_centre_file> favorites)
        {
            IsCheckIOBusy = true;
            FileCollection.Clear();

            foreach (var mFile in favorites)
            {
                //Get Icons
                
                string shortCutPath = mFile.file_full_nm;
                string icon = IconUtilities.GetIconString(shortCutPath);
                
                FileInfo fileInfo = new FileInfo(mFile.file_path_txt);
                TCFile file = new TCFile(fileInfo.Name, fileInfo.FullName, previousFolder, TCFile.TCType.FAVORITE, icon); //new TCFile(fileInfo, image, true);
                file.DoubleClickEvent += File_DoubleClickEvent;
                file.FileClickedEvent += File_FileClickedEvent;
                file.InfoPanelClickEvent += File_InfoPanelClickEvent;
                file.FavouriteClickEvent += File_FavouriteClickEvent;
                FileCollection.Add(file);
            }
            IsCheckIOBusy = false;
        }

        private void File_DoubleClickEvent(object sender, FileClickedEventArgs args)
        {
            HandleClick(sender, args, true);
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            IsCheckIOBusy = true;            
            _eventAggregator.GetEvent<PubSubEvent<string>>().Publish("navReferenceCentre");
            IsCheckIOBusy = false;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public void ClearFileFolderMenu()
        {
            FileCollection.Clear();
            if (!isSearchInActive)
                ClearMenu();
        }

        public bool LoadData()
        {
            try
            {
                IsCheckIOBusy = true;
                SelectedFile = null;
                IsRightPanelVisible = false;

                if (isFavoriteView)
                {
                    var favoriteList = _referenceService.GetAllFavouriteFiles();
                    RenderFavorites(favoriteList);
                }
                else
                {
                    //Get Current Directory
                  DirectoryInfo directory = new DirectoryInfo(currentFolder);

                    if (directory.Exists)
                    {
                        List<DirectoryInfo> subDirectorys = null;
                        try
                        {
                            //Get Sub Dir
                            subDirectorys = directory.GetDirectories()?.ToList();
                        }
                        catch (UnauthorizedAccessException)
                        {
                            var errorTitle = Properties.Resource.errorMsgUnautorizedAccessTitle;
                            var errorMessage = Properties.Resource.errorMsgUnautorizedAccessMessage;
                            MessageBox.Show(errorMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Warning);
                            IsCheckIOBusy = false;
                            return false;
                        }
                        catch (Exception)
                        {
                            var errorTitle = Properties.Resource.errorMsgUnautorizedAccessTitle;
                            var errorMessage = Properties.Resource.errorMsgUnautorizedAccessMessage;
                            MessageBox.Show(errorMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Warning);
                            IsCheckIOBusy = false;
                            return false;
                        }
                        
                        //Clear existing Items from the View
                        ClearFileFolderMenu();

                        //Generate Menu
                        if (!isSearchInActive)
                        {
                            GenerateMenu(directory);
                        }

                        //Render Directories
                        RenderDirectoriesInView(subDirectorys);

                        //Render Files
                        var files = directory.GetFiles();
                        var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden))?.ToList();
                        RenderFilesInView(filtered, false);
                    }
                    else
                    {
                        //TODO: Throw Error
                        Console.WriteLine("Dir does not exist!");
                    }
                }
                IsCheckIOBusy = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                return false;
            }
            finally { }
        }

        private void GenerateMenu(DirectoryInfo directory)
        {
            try
            {
                bool isRoot = (rootFolderPath == currentFolder);
                var newFolderMenu = new List<TCFile>();
                int i = 0;
                var menuItem = new TCFile(directory.Name, directory.FullName, previousFolder, TCFile.TCType.MENU, null);//new TCFile(directory, i, false);
                menuItem.IsFolder = true;
                menuItem.FileClickedEvent += MenuItem_FileClickedEvent;
                newFolderMenu.Add(menuItem);


                if (!isRoot)
                {
                    //Create Navigation Bar                        
                    var navPreviousDir = GetPreviousDirectory(directory);
                    i++;
                    while (true)
                    {
                        menuItem = new TCFile(navPreviousDir.Name, navPreviousDir.FullName, previousFolder, TCFile.TCType.MENU, null);
                        menuItem.IsSystemItem = true;
                        menuItem.IsFolder = true;
                        menuItem.FileClickedEvent += MenuItem_FileClickedEvent;
                        menuItem.Id = i;
                        newFolderMenu.Add(menuItem);
                        if (navPreviousDir.FullName == rootFolder.FullName)
                            break;
                        navPreviousDir = GetPreviousDirectory(navPreviousDir);
                        i++;
                    }

                    //Get Previous Folder
                    var previousDirectory = GetPreviousDirectory(directory);
                    if (previousDirectory != null)
                    {
                        TCFile file = new TCFile("...", previousDirectory.FullName, previousDirectory.FullName, TCFile.TCType.PREVIOUS, IconUtilities.FolderIcon);
                        file.IsSystemItem = true;
                        file.FileClickedEvent += File_FileClickedEvent;
                        FileCollection.Add(file);
                    }
                    else
                    {
                        Console.WriteLine("Error: Previous directory does not exist!");
                    }
                }


                //Add Menu Items
                newFolderMenu = newFolderMenu.OrderByDescending(x => x.Id).ToList();
                foreach (var item in newFolderMenu)
                {
                    FolderMenu.Add(item);
                }
            }
            catch (Exception e)
            {
            }
        }

        private void MenuItem_FileClickedEvent(object sender, FileClickedEventArgs args)
        {
            File_FileClickedEvent(sender, args);
        }

        private DirectoryInfo GetPreviousDirectory(DirectoryInfo currentFolder)
        {
            if (currentFolder != null)
                return currentFolder.Parent;
            else
                return null;
        }

        private ImageSource GetFolderImage()
        {
            var img = ShellIcon.GetLargeFolderIcon();
            Bitmap bitmap = img.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();

            ImageSource image =
                 Imaging.CreateBitmapSourceFromHBitmap(
                      hBitmap, IntPtr.Zero, Int32Rect.Empty,
                      BitmapSizeOptions.FromEmptyOptions());
            return image;
        }
        

        private void HandleClick(object sender, FileClickedEventArgs args, bool isDoubleClick)
        {
            //IsRightPanelVisible = !args.IsFolder;
            var itemGotClicked = sender as TCFile;

            switch (itemGotClicked.TcType)
            {
                case TCFile.TCType.FOLDER:
                case TCFile.TCType.PREVIOUS:
                    HandleFolderClick(itemGotClicked);
                    break;
                case TCFile.TCType.FAVORITE:
                case TCFile.TCType.FILE:
                    if(SelectedFile != null)
                        SelectedFile.IsSelected = false;
                    HandleFileClick(itemGotClicked);
                    break;
                case TCFile.TCType.MENU:
                    HandleMenuClick(itemGotClicked);
                    break;
                case TCFile.TCType.CLEAR:
                    //ClearSearch();
                    SearchTerm = string.Empty;
                    break;
                case TCFile.TCType.SEARCH:
                    Search();
                    break;
                default:
                    break;
            }
        }

        private void HandleMenuClick(TCFile itemGotClicked)
        {
            HandleFolderClick(itemGotClicked);
        }

        private void HandleFolderClick(TCFile itemGotClicked)
        {
            var tempPreviousFolder = previousFolder;
            var tempCurrentFolder = currentFolder;

            previousFolder = currentFolder;
            currentFolder = itemGotClicked.FilePath;

            if (!LoadData())
            {
                previousFolder = tempPreviousFolder;
                currentFolder = tempCurrentFolder;
            }
        }

        private void HandleFileClick(TCFile newSelection)
        {
            try
            {
                UpdateInfoPanelVisibility(newSelection);

                SelectedFile = newSelection;
                if (IsRightPanelVisible)
                {
                    RenderRightPanel();
                    SelectedFile.IsInfoMenuOpen = IsRightPanelVisible;
                }
                OpenFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void RenderRightPanel()
        {
            try
            {
                RightPanelItem = SelectedFile;
                Title = SelectedFile?.FileNameText;
                IconPath = SelectedFile?.IconSourceString;
                FileSize = SelectedFile?.File?.Length.ToString();
                PathText = SelectedFile?.File?.FullName;
                DateCreatedText = SelectedFile?.File?.CreationTime.ToString();
                DateModifiedText = SelectedFile?.File?.LastWriteTime.ToString();
                var isFileInFavorite = SelectedFile.IsFavorited; //_referenceService.IsFileInFavorite(PathText);                
                UpdateFavoriteTitle(SelectedFile);
            }
            catch (Exception)
            {
            }
        }

        private void UpdateFavoriteTitle(TCFile selection)
        {
            IsFileInFavorites = selection.IsFavorited; //_referenceService.IsFileInFavorite(fullPath);
            
            
        }

        private void File_FileClickedEvent(object sender, FileClickedEventArgs args)
        {
         
                HandleClick(sender, args, false);
            
        }
    }
}
