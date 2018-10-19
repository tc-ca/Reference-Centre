using MTCO.InspectionMobileApp.Local.DTO;
using System.Data.Entity.ModelConfiguration;

namespace MTCO.InspectionMobileApp.Local.DataAccess
{
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
