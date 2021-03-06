namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty208_xref_standard_response
    {
        public string standard_response_cd { get; set; }
        public long template_item_cd { get; set; }
        public string parent_standard_response_cd { get; set; }
        public long parent_template_item_cd { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    }
    public class ty208_xref_standard_responseConfiguration : EntityTypeConfiguration<ty208_xref_standard_response>
    {
        public ty208_xref_standard_responseConfiguration()
        {
            this.ToTable("SIRS.ty208_xref_standard_response");
            this.HasKey(s => new { s.standard_response_cd, s.template_item_cd, s.parent_standard_response_cd, s.parent_template_item_cd });
            this.Property(e => e.standard_response_cd);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.parent_standard_response_cd);
            this.Property(e => e.parent_template_item_cd);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
