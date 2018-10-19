using System;

namespace MTCO.InspectionMobileApp.Local.DTO
{
    public partial class cc310_reference_centre_file
    {
        public int file_id { get; set; }
        public string file_nm { get; set; }
        public string file_path_txt { get; set; }
        public string file_full_nm { get; set; }
        public Nullable<int> file_size_nbr { get; set; }
        public string date_created_dte { get; set; }
        public string date_deleted_dte { get; set; }
        public string date_last_update_dte { get; set; }
        public Nullable<int> user_last_update_id { get; set; }
    }
}
