namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc302_inspection_profile
    {
        public decimal inspection_id { get; set; }
        public long template_item_cd { get; set; }
        public string standard_response_cd { get; set; }
        public string non_standard_response_txt { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual cc301_inspection cc301_inspection { get; set; }
        public virtual ty206_template_item ty206_template_item { get; set; }
    }
    public class cc302_inspection_profileConfiguration : EntityTypeConfiguration<cc302_inspection_profile>
    {
        public cc302_inspection_profileConfiguration()
        {
            this.ToTable("SIRS.cc302_inspection_profile");
            this.HasKey(s => new { s.inspection_id, s.template_item_cd });
            this.Property(e => e.inspection_id);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.standard_response_cd);
            this.Property(e => e.non_standard_response_txt);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
