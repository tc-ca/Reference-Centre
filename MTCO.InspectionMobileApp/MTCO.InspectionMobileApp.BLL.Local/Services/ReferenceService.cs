using MTCO.InspectionMobileApp.BLL.Local.Contracts.Reference;
using System.Collections.ObjectModel;
using System.Linq;
using MTCO.InspectionMobileApp.Local.DataAccess;
using MTCO.InspectionMobileApp.Local.DTO;

namespace MTCO.InspectionMobileApp.BLL.Local.Services.Reference
{
    public class ReferenceService : IReferenceService
    {
        LocalFactory factory;
        public ReferenceService(LocalFactory factory)
        {
            this.factory = factory;
        }
        public void AddToFavourites(cc310_reference_centre_file file)
        {
            using (LocalContext context = factory.CreateLocalContext())
            {
                if (!IsFileInFavorite(file.file_full_nm))
                {
                    context.cc310_reference_centre_file.Add(file);
                    context.SaveChanges();
                }
            }
        }

        public void RemoveFromFavourites(string fileFullName)
        {
            using (LocalContext context = factory.CreateLocalContext())
            {
                var targetFile = context.cc310_reference_centre_file.FirstOrDefault(i => i.file_full_nm == fileFullName);
                if(targetFile !=  null)
                {
                    context.cc310_reference_centre_file.Remove(targetFile);
                    context.SaveChanges();
                }
            }
        }

        public ObservableCollection<cc310_reference_centre_file> GetAllFavouriteFiles()
        {

            using (LocalContext context = factory.CreateLocalContext())
            {
                ObservableCollection<cc310_reference_centre_file> list = new ObservableCollection<cc310_reference_centre_file>();
                list = new ObservableCollection<cc310_reference_centre_file>(context.cc310_reference_centre_file.ToList());
                return list;
            }
        }

        public bool IsFileInFavorite(string fileFullPath)
        {
            using (LocalContext context = factory.CreateLocalContext())
            {
                var targetFile = context.cc310_reference_centre_file.FirstOrDefault(i => i.file_path_txt == fileFullPath);
                
                return (!(targetFile == null));
            }
        }

        public ObservableCollection<cc310_reference_centre_file> SearchFavorite(string FileName)
        {
            using (LocalContext context = factory.CreateLocalContext())
            {
                ObservableCollection<cc310_reference_centre_file> list = new ObservableCollection<cc310_reference_centre_file>();
                list = new ObservableCollection<cc310_reference_centre_file>(context.cc310_reference_centre_file.Where(i => i.file_nm.ToLower().Contains(FileName.ToLower())));
                return list;
            }
        }
    }
}
