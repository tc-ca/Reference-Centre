namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class mv303_insp_item_detail
    {
        public decimal inspection_id { get; set; }
        public Nullable<decimal> inspection_item_id { get; set; }
        public string deficiency_cd { get; set; }
        public string applicable_regulation { get; set; }
        public string comments { get; set; }
        public string compliance_dte { get; set; }
        public string closed_by { get; set; }
        public string user_nm { get; set; }
        public string closed_dte { get; set; }
        public string corrective_action_history { get; set; }
    }
    public class mv303_insp_item_detailConfiguration : EntityTypeConfiguration<mv303_insp_item_detail>
    {
        public mv303_insp_item_detailConfiguration()
        {
            this.ToTable("SIRS.mv303_insp_item_detail");
            this.HasKey(s => s.inspection_id);
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_item_id);
            this.Property(e => e.deficiency_cd);
            this.Property(e => e.applicable_regulation);
            this.Property(e => e.comments);
            this.Property(e => e.compliance_dte);
            this.Property(e => e.closed_by);
            this.Property(e => e.user_nm);
            this.Property(e => e.closed_dte);
            this.Property(e => e.corrective_action_history);
        }
    }


}
