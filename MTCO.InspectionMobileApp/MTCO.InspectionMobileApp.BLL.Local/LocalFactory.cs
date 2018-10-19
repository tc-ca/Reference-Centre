using MTCO.InspectionMobileApp.Local.DataAccess;

namespace MTCO.InspectionMobileApp.BLL.Local
{
    public class LocalFactory
    {
        public LocalFactory()
        {

        }
    
        public virtual LocalContext CreateLocalContext()
        {
            return new LocalContext();
        }
    }
}
