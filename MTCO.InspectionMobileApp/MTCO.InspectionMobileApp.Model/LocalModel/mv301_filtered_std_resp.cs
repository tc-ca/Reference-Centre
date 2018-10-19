namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class mv301_filtered_std_resp
    {
        public decimal template_item_cd { get; set; }
        public string standard_response_cd { get; set; }
        public string standard_response_etxt { get; set; }
        public string standard_response_ftxt { get; set; }
        public Nullable<long> parent_template_item_cd { get; set; }
        public string parent_standard_response_cd { get; set; }
    }
    public class mv301_filtered_std_respConfiguration : EntityTypeConfiguration<mv301_filtered_std_resp>
    {
        public mv301_filtered_std_respConfiguration()
        {
            this.ToTable("SIRS.mv301_filtered_std_resp");
            this.HasKey(s => s.template_item_cd);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.standard_response_cd);
            this.Property(e => e.standard_response_etxt);
            this.Property(e => e.standard_response_ftxt);
            this.Property(e => e.parent_template_item_cd);
            this.Property(e => e.parent_standard_response_cd);
        }
    }


}
