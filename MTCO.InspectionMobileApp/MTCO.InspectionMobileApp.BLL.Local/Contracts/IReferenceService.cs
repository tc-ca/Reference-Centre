using MTCO.InspectionMobileApp.Local.DTO;
using System.Collections.ObjectModel;

namespace MTCO.InspectionMobileApp.BLL.Local.Contracts.Reference
{
    public interface IReferenceService
    {
        void AddToFavourites(cc310_reference_centre_file file);
        void RemoveFromFavourites(string fileFullName);
        ObservableCollection<cc310_reference_centre_file> GetAllFavouriteFiles();
        bool IsFileInFavorite(string fileFullPath);
        ObservableCollection<cc310_reference_centre_file> SearchFavorite(string FileName);
    }
}
