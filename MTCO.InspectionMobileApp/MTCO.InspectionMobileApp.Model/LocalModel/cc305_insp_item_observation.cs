namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc305_insp_item_observation
    {
        public long insp_item_observation_id { get; set; }
        public decimal inspection_id { get; set; }
        public decimal inspection_item_id { get; set; }
        public long template_item_cd { get; set; }
        public string standard_response_cd { get; set; }
        public string non_standard_response_txt { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    }
    public class cc305_insp_item_observationConfiguration : EntityTypeConfiguration<cc305_insp_item_observation>
    {
        public cc305_insp_item_observationConfiguration()
        {
            this.ToTable("SIRS.cc305_insp_item_observation");
            this.HasKey(s => s.insp_item_observation_id);
            this.Property(e => e.insp_item_observation_id);
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_item_id);
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
