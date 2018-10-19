namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ac201_inspection_user
    {
        public ac201_inspection_user()
        {
            this.cc309_inspector_assignment = new HashSet<cc309_inspector_assignment>();
        }
    
        public decimal inspection_user_id { get; set; }
        public string user_nm { get; set; }
        public string user_first_nm { get; set; }
        public string user_last_nm { get; set; }
        public Nullable<System.DateTime> date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public Nullable<System.DateTime> date_last_update_dte { get; set; }
        public Nullable<decimal> user_last_update_id { get; set; }
    
        public virtual ICollection<cc309_inspector_assignment> cc309_inspector_assignment { get; set; }
    }
    public class ac201_inspection_userConfiguration : EntityTypeConfiguration<ac201_inspection_user>
    {
        public ac201_inspection_userConfiguration()
        {
            this.ToTable("SIRS.ac201_inspection_user");
            this.HasKey(s => s.inspection_user_id);
            this.HasMany(m => m.cc309_inspector_assignment).WithRequired(s => s.ac201_inspection_user);
            this.Property(e => e.inspection_user_id);
            this.Property(e => e.user_nm);
            this.Property(e => e.user_first_nm);
            this.Property(e => e.user_last_nm);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
