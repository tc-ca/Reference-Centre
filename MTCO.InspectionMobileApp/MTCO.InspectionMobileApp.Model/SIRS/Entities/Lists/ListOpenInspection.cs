using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class ListOpenInspection 
    {
        public int InspectionID { get; set; }
        public string VesselName { get; set; }
        public string FormerVesselName { get; set; }
        public int? FileNumberNo { get; set; }
        public int? OfficialNumber { get; set; }
        public DateTime? InspectionDate { get; set; }
        public bool IsCheckedOut { get; set; }
        public bool IsNotCheckedOut
        {
            get
            {
                return !IsCheckedOut;
            }
        }
        public string Action { get; set; }


        public string InspectionType { get; set; }

        public bool IsMobileAvailable
        {
            get
            {
                if (InspectionType == "S" || InspectionType == "MU")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        [NotMapped]
        public DateTime? InspectionDateObj { get; internal set; }
    }
}
