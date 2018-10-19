namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc310_reference_centre_file
    {
        public long file_id { get; set; }
        public string file_nm { get; set; }
        public string file_path_txt { get; set; }
        public string file_full_nm { get; set; }
        public Nullable<long> file_size_nbr { get; set; }
        public string date_created_dte { get; set; }
        public string date_deleted_dte { get; set; }
        public string date_last_update_dte { get; set; }
        public Nullable<long> user_last_update_id { get; set; }
    }
    public class cc310_reference_centre_fileConfiguration : EntityTypeConfiguration<cc310_reference_centre_file>
    {
        public cc310_reference_centre_fileConfiguration()
        {
            this.ToTable("SIRS.cc310_reference_centre_file");
            this.HasKey(s => s.file_id);
            this.Property(e => e.file_id);
            this.Property(e => e.file_nm);
            this.Property(e => e.file_path_txt);
            this.Property(e => e.file_full_nm);
            this.Property(e => e.file_size_nbr);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
