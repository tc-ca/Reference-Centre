# Reference-Centre
![Screenshot of Reference Centre](rce1.png?raw=true "Screenshot of Reference Centre")
The Reference Centre is .net WPF application that was designed for Transport Canada Inspectors to quickly retrieve documents stored on a network drive that was setup with Windows Sync (Always Available Offline). 


It was originally designed for Tablets running on Windows 8.1 and has been tested on Windows 10, it provides quick:

1. Folder Navigation
2. File and Folder Name Search
3. Add/Remove Favorites

![Screenshot of Reference Centre](rcfe1.png?raw=true "Screenshot of Reference Centre")

## Requirements
- Visual Studio 2019
- .NET Framework 4.7.1 
- NuGet Package Manager (usually comes with Visual Studio)
- PRISM (should be restored through NuGet)
- EF6 (should be restored through NuGet)
- SQLite (should be restored through NuGet)
- System with Windows 7 and up with 4GB RAM or better

## Setup
### How To Compile The Application
- Load the project in Visual Studio 2019
- Restore NuGet Packages ([see the instruction below](#how-to-restore-nuget-pakcages)).
- Press "F5" key or Go to Debug Menu in Visual Studio and select "Start Debugging"

### Changing Folder Location
If you wish to point to a specific folder, you need to modify the "App.Config" file in the root directory.
Then you need to find the *"OfflineDrivePath"* Key and set to your desired path (usually the default path is set to *"C:\\"*).

## How to restore NuGet Packages
If you're using Visual Studio, first enable package restore as follows. Otherwise continue to the sections that follow.

* Select the Tools > NuGet Package Manager > Package Manager Settings.
* Set both options under Package Restore.
* Select OK.
* Build your project again.
> Please review the following link for further help with NuGet:
https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore-troubleshooting


# Centre de référence 
![Centre de référence](rcf1.png?raw=true "Centre de référence")
Le Centre de référence est une application .net WPF conçue pour que les inspecteurs de Transports Canada récupèrent rapidement des documents stockés sur un lecteur réseau configuré avec Windows Sync (toujours disponible hors ligne). 

Il a été initialement conçu pour les tablettes fonctionnant sous Windows 8.1 et a été testé sur Windows 10, il fournit rapidement: 

1. La navigation dans les dossiers 
2. La recherche par nom de fichier et de dossier 
3. L’ajout et la suppression de favoris 

 ![Centre de référence ](rcff1.png?raw=true "Centre de référence ")

## Exigences 
- Visual Studio 2019 
- .NET Framework 4.7.1 
- Gestionnaire de package NuGet (généralement fourni avec Visual Studio) 
- PRISM (doit être restauré par NuGet) 
- EF6 (doit être restauré par NuGet) 
- SQLite (doit être restauré par NuGet) 
- Système avec Windows 7 et plus avec 4 Go de RAM ou plus 


## Installer 
### Comment compiler l'application 
- Charger le projet dans Visual Studio 2019 
- Restaurez les packages NuGet ([voir les instructions ci-dessous](#Comment-restaurer-des-packages-NuGet)). 
- Appuyez sur la touche "F5" ou allez au menu de débogage dans Visual Studio et sélectionnez "Démarrer le débogage" 

### Modification de l'emplacement du dossier 
Si vous souhaitez pointer vers un dossier spécifique, vous devez modifier le fichier "App.Config" dans le répertoire racine. Ensuite, vous devez trouver la clé "OfflineDrivePath" et définir le chemin souhaité (généralement le chemin par défaut est défini sur "C: \"). 

## Comment restaurer des packages NuGet 
- Si vous utilisez Visual Studio, activez d'abord la restauration de package comme suit. Sinon, passez aux sections suivantes. 
- Sélectionnez Outils > Gestionnaire de package NuGet > Paramètres du Gestionnaire de package. 
- Définissez les deux options sous Restauration de packages. 
- Sélectionnez OK. 
- Générerez votre projet. 

Veuillez consulter le lien suivant pour obtenir de l'aide sur NuGet: https://docs.microsoft.com/fr-fr/nuget/consume-packages/package-restore-troubleshooting  
