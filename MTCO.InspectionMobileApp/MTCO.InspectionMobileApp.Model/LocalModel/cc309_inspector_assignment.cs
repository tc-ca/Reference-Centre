namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc309_inspector_assignment
    {
        public decimal inspection_id { get; set; }
        public decimal inspection_user_id { get; set; }
        public string inspection_user_type { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_date { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public Nullable<decimal> user_last_update_id { get; set; }
        public string inspector_name { get; set; }
    
        public virtual ac201_inspection_user ac201_inspection_user { get; set; }
        public virtual cc301_inspection cc301_inspection { get; set; }
    }
    public class cc309_inspector_assignmentConfiguration : EntityTypeConfiguration<cc309_inspector_assignment>
    {
        public cc309_inspector_assignmentConfiguration()
        {
            this.ToTable("SIRS.cc309_inspector_assignment");
            this.HasKey(s => new { s.inspection_id, s.inspection_user_id });
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_user_id);
            this.Property(e => e.inspection_user_type);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_date);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
            this.Property(e => e.inspector_name);
        }
    }


}
