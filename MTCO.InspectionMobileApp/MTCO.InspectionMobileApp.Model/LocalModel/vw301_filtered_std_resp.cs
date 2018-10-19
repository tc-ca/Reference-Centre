namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class vw301_filtered_std_resp
    {
        public long template_item_cd { get; set; }
        public string standard_response_cd { get; set; }
        public string standard_response_etxt { get; set; }
        public string standard_response_ftxt { get; set; }
        public int parent_template_item_cd { get; set; }

    }
    public class vw301_filtered_std_respConfiguration : EntityTypeConfiguration<vw301_filtered_std_resp>
    {
        public vw301_filtered_std_respConfiguration()
        {
            this.ToTable("SIRS.vw301_filtered_std_resp");
            this.HasKey(s => new { s.template_item_cd, s.standard_response_cd, s.standard_response_etxt, s.standard_response_ftxt });
            this.Property(e => e.template_item_cd);
            this.Property(e => e.standard_response_cd);
            this.Property(e => e.standard_response_etxt);
            this.Property(e => e.standard_response_ftxt);
            this.Property(e => e.parent_template_item_cd);
        }
    }


}
