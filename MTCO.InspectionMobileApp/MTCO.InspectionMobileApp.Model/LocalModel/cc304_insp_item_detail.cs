namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc304_insp_item_detail
    {
        public long insp_item_detail_id { get; set; }
        public decimal inspection_item_id { get; set; }
        public decimal inspection_id { get; set; }
        public long template_item_cd { get; set; }
        public string standard_response_cd { get; set; }
        public string non_standard_response_txt { get; set; }
        public string remarks_txt { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
        public System.DateTime date_def_created_dte { get; set; }
    }
    public class cc304_insp_item_detailConfiguration : EntityTypeConfiguration<cc304_insp_item_detail>
    {
        public cc304_insp_item_detailConfiguration()
        {
            this.ToTable("SIRS.cc304_insp_item_detail");
            this.HasKey(s => s.insp_item_detail_id);
            this.Property(e => e.insp_item_detail_id);
            this.Property(e => e.inspection_item_id);
            this.Property(e => e.inspection_id);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.standard_response_cd);
            this.Property(e => e.non_standard_response_txt);
            this.Property(e => e.remarks_txt);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.date_def_created_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
