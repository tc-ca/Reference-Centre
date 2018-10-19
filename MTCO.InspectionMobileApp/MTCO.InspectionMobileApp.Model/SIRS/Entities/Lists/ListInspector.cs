
namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class ListInspector
    {
        public decimal InspectionID { get; set; }
        public string Name { get; set; }
        public string InspectorType { get; set; }
        public decimal UserID { get; set; }


        public bool IsSupport { get { return InspectorType == "S"; } }
            
        




    }
}
