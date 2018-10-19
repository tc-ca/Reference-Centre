using Shell32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MTCO.InspectionMobileApp.ReferenceCentre.Common
{
    internal static class IconUtilities
    {
        public enum SupportedIcons { file, xlsx, url, docx, pptx, ai, avi, css, csv, dbf, doc, dwg, exe, fla, html, iso, jpg, js, json, mp3, mp4, pdf, png, ppt, psd, rtf, svg, txt, xls, xml, zip }

        public static string ICON_ROOT = "/MTCO.InspectionMobileApp.ReferenceCentre;component/Images/Icons/";
        public static string ICON_FILE_TYPE = ".png";
        public static string DefaultFileType = $"{ICON_ROOT}file{ICON_FILE_TYPE}";
        public static string FolderIcon = $"{ICON_ROOT}folder{ICON_FILE_TYPE}";

        public static Dictionary<string, ImageSource> iconSource = new Dictionary<string, ImageSource>();


        public static string GetIconString(string filePath)
        {
            try
            {
                var extension = GetExtension(filePath)?.Replace(".", string.Empty).ToLower();
                
                if(Enum.IsDefined(typeof(SupportedIcons), extension))
                {
                    var iconPath = $"{ICON_ROOT}{extension}{ICON_FILE_TYPE}";
                    return iconPath; 
                }
                else
                {
                    return DefaultFileType;
                }
            }
            catch (Exception)
            {
                return DefaultFileType;
            }
        }

        public static ImageSource GetIconForShortCut(string filePath)
        {   
            var realPath = GetShortcutTargetFilesFullPath(filePath);
            return GetIcon(realPath);
        }

        public static ImageSource GetIcon(string filePath)
        {
            ImageSource image = null;
            var extension = GetExtension(filePath);

            if (string.IsNullOrEmpty(extension))
            {
                return null;
            }

            if (!iconSource.ContainsKey(extension))
            {
                Icon img = Icon.ExtractAssociatedIcon(filePath);
                Bitmap bitmap = img.ToBitmap();
                IntPtr hBitmap = bitmap.GetHbitmap();

                image =
                     Imaging.CreateBitmapSourceFromHBitmap(
                          hBitmap, IntPtr.Zero, Int32Rect.Empty,
                          BitmapSizeOptions.FromEmptyOptions());
                iconSource.Add(extension, image);
            }
            else
            {
                image = iconSource[extension];
            }

            return image;
        }

        public static string GetExtensionForShortcut(string shortcutPath)
        {
            var realPath = GetShortcutTargetFilesFullPath(shortcutPath);
            return Path.GetExtension(realPath);
        }

        public static string GetExtension(string filePath)
        {   
            return Path.GetExtension(filePath);
        }

        public static string GetShortcutTargetFilesFullPath(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);

            Shell shell = new Shell();
            Folder folder = shell.NameSpace(pathOnly);
            FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                ShellLinkObject link = (ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty;
        }
    }
}
