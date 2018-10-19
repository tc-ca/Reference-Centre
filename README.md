# Reference-Centre
![Screenshot of Reference Centre](Reference%20Centre%20Screen%201.PNG?raw=true "Screenshot of Reference Centre")
The Reference Centre is .net WPF application that was designed for Transport Canada Inspectors to quickly retrieve documents stored on a network drive that was setup with Windows Sync (Always Available Offline). 


It was originally designed for Tablets running on Windows 8.1 and has been tested on Windows 10, it provides quick:

1. Folder Navigation
2. File and Folder Name Search
3. Add/Remove Favorites

![Screenshot of Reference Centre](Reference%20Centre%20Favourites%20Screen%202.PNG?raw=true "Screenshot of Reference Centre")

## Requirements
- Visual Studio 2017
- .NET Framework 4.5
- NuGet Package Manager (usually comes with Visual Studio)
- PRISM (should be restored through NuGet)
- EF6 (should be restored through NuGet)
- SQLite (should be restored through NuGet)
- System with Windows 7 and up with 4GB RAM or better

## Setup
### How To Compile The Application
- Load the project in Visual Studio 2017
- Restore NuGet Packages ([see the instruction below](#how-to-restore-nuget-pakcages)).
- Press "F5" key or Go to Debug Menu in Visual Studio and select "Start Debugging"

### Changing Folder Location
If you wish to point to a specific folder, you need to modify the "App.Config" file in the root directory.
Then you need to find the *"OfflineDrivePath"* Key and set to your desired path (usually the default path is set to *"C:\\"*).

## How to restore NuGet Packages
If you're using Visual Studio, first enable package restore as follows. Otherwise continue to the sections that follow.

* Select the Tools > NuGet Package Manager > Package Manager Settings menu command.
* Set both options under Package Restore.
* Select OK.
* Build your project again.
> Please review the following link for further help with NuGet:
https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore-troubleshooting
