using System;

namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class ListCheckedOutInspection 
    {
        public decimal InspectionID { get; set; }
        public string VesselName { get; set; }
        public string FormerVesselName { get; set; }
        public decimal? FileNumberNo { get; set; }
        public decimal? OfficialNumber { get; set; }
        public DateTime? InspectionDate { get; set; }

    }
}
