using System;
using System.IO;

namespace MTCO.InspectionMobileApp.ReferenceCentre.Models
{
    public class FileClickedEventArgs : EventArgs
    {
        private readonly string fileClickedPath;
        private readonly bool isFolder;
        private readonly bool isInfoPanelClicked;
        private readonly bool isFavouriteClicked;

        private readonly FileInfo info;

        public FileClickedEventArgs()
        {
            isFolder = false;
            isInfoPanelClicked = false;
        }

        public FileClickedEventArgs(string fileClickedPath, bool isFolder)
        {
            this.fileClickedPath = fileClickedPath;
            this.isFolder = isFolder;
        }

        public FileClickedEventArgs(string fileClickedPath, bool isFolder, FileInfo info): this(fileClickedPath, isFolder)
        {
            this.info = info;
        }

        public FileClickedEventArgs(string fileClickedPath, bool isFolder, FileInfo info, bool isInfoPanelVisible) : this(fileClickedPath, isFolder, info)
        {
            this.isInfoPanelClicked = isInfoPanelVisible;
        }

        public FileClickedEventArgs(string fileClickedPath, bool isFolder, FileInfo info, bool isInfoPanelClicked, bool isFavouriteClicked) : this(fileClickedPath, isFolder, info, isInfoPanelClicked)
        {
            this.isFavouriteClicked = isFavouriteClicked;
        }

        public string FileClickedPath
        {
            get { return fileClickedPath; }
        }

        public bool IsFolder
        {
            get { return isFolder; }
        }

        public FileInfo Info
        {
            get { return info; }
        }

        public bool IsInfoPanelVisible
        {
            get { return isInfoPanelClicked; }
        }

        public bool IsFavouriteClicked
        {
            get { return isFavouriteClicked; }
        }
    }
}
