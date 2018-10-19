using Prism.Commands;
using System.Windows.Media;
using System.Windows.Input;
using System.IO;
using Prism.Mvvm;
using System;

namespace MTCO.InspectionMobileApp.ReferenceCentre.Models
{
    public class TCFile: BindableBase
    {
        public enum TCType { FOLDER, FILE, MENU, CLEAR, SEARCH, FAVORITE, PREVIOUS}
        public delegate void FileClickedEventHandler(object sender, FileClickedEventArgs args);

        public event FileClickedEventHandler FileClickedEvent;
        public event FileClickedEventHandler DoubleClickEvent;
        public event FileClickedEventHandler InfoPanelClickEvent;
        public event FileClickedEventHandler FavouriteClickEvent;
        private FileClickedEventArgs fileClickedArg;

        public int Id { get; set; }

        private string iconSourceString;
        public string IconSourceString
        {
            get { return iconSourceString; }
            set { SetProperty(ref iconSourceString, value); }
        }

        private TCType tcType;
        public TCType TcType
        {
            get { return tcType; }
            set { SetProperty(ref tcType, value); }
        }

        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { SetProperty(ref filePath, value); }
        }

        private string previousFolderPath;
        public string PreviousFolderPath
        {
            get { return previousFolderPath; }
            set { SetProperty(ref previousFolderPath, value); }
        }

        private bool isSystemItem;
        public bool IsSystemItem
        {
            get { return isSystemItem; }
            set { SetProperty(ref isSystemItem, value); }
        }

        private bool isInfoMenuOpen;
        public bool IsInfoMenuOpen
        {
            get { return isInfoMenuOpen; }
            set { SetProperty(ref isInfoMenuOpen, value); }
        }

        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                SetProperty(ref isSelected, value);
            }
        }

        private DirectoryInfo dir;
        public DirectoryInfo Dir
        {
            get { return dir; }
            set { SetProperty(ref dir, value); }
        }
        
        private FileInfo file;
        public FileInfo File
        {
            get { return file; }
            set { SetProperty(ref file, value);}
        }

        private string fileName;
        public string FileNameText
        {
            get
            {
                return fileName;
            }
            set
            {
                SetProperty(ref fileName, value);
            }
        }

        private bool isFolder;
        public bool IsFolder
        {
            get { return isFolder; }
            set { SetProperty(ref isFolder, value);}
        }

        private ImageSource iconSource;
        public ImageSource IconSource {
            get
            {
                return iconSource;
            }
            set
            {
                SetProperty(ref iconSource, value);
            }
        }

        private bool isFavorited;
        public bool IsFavorited
        {
            get { return isFavorited; }
            set { SetProperty(ref isFavorited, value); }
        }


        public ICommand OpenFolderCommand
        {
            get
            {
                return new DelegateCommand(OpenFolder);
            }
        }

        public ICommand MouseDoubleClickCommand
        {
            get
            {
                return new DelegateCommand(DoubleClickOpen);
            }
        }

        public ICommand InfoPanelCheckCommand
        {
            get
            {
                return new DelegateCommand(CheckedInfoPanel);
            }
        }

        public ICommand FavoriteCheckCommand
        {
            get
            {
                return new DelegateCommand(FavoriteClicked);
            }
        }

        public TCFile()
        {
            isInfoMenuOpen = false;
            isSystemItem = false;
            isFolder = false;
            isSelected = false;
            isFavorited = false;
        }

        public TCFile(string name, string filePath, string previousFolder, TCType tcType, string iconSource) : this()
        {
            if((!string.IsNullOrEmpty(name)) && (TcType == TCType.FOLDER) && string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(name)))
            {
                FileNameText = name;
            }
            else
            {
                FileNameText = (name == "...") ? name : (string.IsNullOrEmpty(name)) ? string.Empty : Path.GetFileNameWithoutExtension(name);
            }
            
            FilePath = filePath;
            TcType = tcType;
            IconSourceString = iconSource;

            switch (tcType)
            {
                case TCType.FILE:
                    IsFolder = false;
                    break;
                case TCType.PREVIOUS:
                    IsSystemItem = true;
                    IsFolder = true;
                    break;
                case TCType.FOLDER:
                    IsFolder = true;
                    break;
                case TCType.FAVORITE:
                    IsFolder = false;
                    IsFavorited = true;
                    break;
                default:
                    break;
            }

            if (tcType == TCType.FILE || tcType == TCType.FAVORITE)
            {
                try
                {
                    File = new FileInfo(FilePath);
                }
                catch (Exception)
                {
                }
            }

            fileClickedArg = new FileClickedEventArgs(FilePath, isFolder, file);
        }

        public TCFile(string filePath, ImageSource iconSource) : this()
        {
            FileNameText = Path.GetFileNameWithoutExtension(filePath);
            FilePath = filePath;
            IconSource = iconSource;
            fileClickedArg = new FileClickedEventArgs(FilePath, isFolder, file);
        }

        public TCFile(FileInfo file, ImageSource iconSource, bool isFavorite):this()
        {
            IsFavorited = isFavorite;
            this.file = file;
            FileNameText = Path.GetFileNameWithoutExtension(file.Name);
            FilePath = file.FullName;
            IconSource = iconSource;
            isFolder = false;
            fileClickedArg = new FileClickedEventArgs(FilePath, isFolder, file);
        }

        public TCFile(DirectoryInfo dir, ImageSource iconSource) : this(dir.Name, iconSource)
        {
            this.dir = dir;
            isFolder = true;
            FilePath = dir.FullName;
            fileClickedArg = new FileClickedEventArgs(dir.FullName, isFolder);
        }

        public TCFile(DirectoryInfo dir, ImageSource iconSource, bool isPreviousDir) : this(dir,iconSource)
        {
            IsSystemItem = isPreviousDir;
            FileNameText = @"...";
            isFolder = true;
            FilePath = dir.FullName;
            fileClickedArg = new FileClickedEventArgs(dir.FullName, isFolder);            
        }

        public TCFile(DirectoryInfo dir, int id, bool isSystemItem) : this()
        {
            IsSystemItem = isSystemItem;
            this.dir = dir;
            Id = id;
            FileNameText = dir.Name;
            FilePath = dir.Name;
            fileClickedArg = new FileClickedEventArgs(dir.FullName, true);
        }
        
        public void OpenFolder()
        {   
            IsSelected = !IsSelected;
            FileClickedEvent?.Invoke(this, fileClickedArg);
            IsInfoMenuOpen = !IsFolder;
        }

        public void DoubleClickOpen()
        {
            IsSelected = !IsSelected;

            if (IsFolder)
            {
                FileClickedEvent?.Invoke(this, fileClickedArg);
            }
            else
            {
                DoubleClickEvent?.Invoke(this, fileClickedArg);
            }
        }

        public void CheckedInfoPanel()
        {
            var arg = new FileClickedEventArgs(file.FullName, isFolder, file, IsInfoMenuOpen);
            InfoPanelClickEvent?.Invoke(this, arg);
        }

        public void FavoriteClicked()
        {
            FileClickedEventArgs arg = new FileClickedEventArgs(FilePath, false, file, IsInfoMenuOpen, isFavorited);
            FavouriteClickEvent?.Invoke(this, arg);
        }

    }
}
