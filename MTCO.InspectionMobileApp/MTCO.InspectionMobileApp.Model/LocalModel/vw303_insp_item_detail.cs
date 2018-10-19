namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public partial class vw303_insp_item_detail
    {
        public decimal inspection_id { get; set; }
        public int inspection_item_id { get; set; }

        public DateTime date_created_dte { get; set; }
        public DateTime? date_def_created_dte { get; set; }
        public DateTime? date_deleted_dte { get; set; }
        public DateTime date_last_update_dte { get; set; }
        public string deficiency_cd { get; set; }
        public string applicable_regulation { get; set; }
        public string comments { get; set; }
        public string compliance_dte { get; set; }
        public string closed_by { get; set; }
        public string user_nm { get; set; }
        public string closed_dte { get; set; }
        public string corrective_action_history { get; set; }
        public string extended_compliance_dte { get; set; }
    }

    public class vw303_insp_item_detailConfiguration : EntityTypeConfiguration<vw303_insp_item_detail>
    {
        public vw303_insp_item_detailConfiguration()
        {
            this.ToTable("SIRS.vw303_insp_item_detail");
            this.HasKey(s => new { s.inspection_id, s.inspection_item_id });
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_item_id);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_def_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.deficiency_cd);
            this.Property(e => e.applicable_regulation);
            this.Property(e => e.comments);
            this.Property(e => e.compliance_dte);
            this.Property(e => e.closed_by);
            this.Property(e => e.user_nm);
            this.Property(e => e.closed_dte);
            this.Property(e => e.corrective_action_history);
            this.Property(e => e.extended_compliance_dte);
        }
    }

}
