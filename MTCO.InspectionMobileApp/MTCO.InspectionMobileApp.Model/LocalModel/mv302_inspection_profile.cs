namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class mv302_inspection_profile
    {
        public decimal inspection_id { get; set; }
        public string document_nbr { get; set; }
        public string inspector_nm { get; set; }
        public string inspector_signature_dte { get; set; }
        public string representative_nm { get; set; }
        public string representative_signature_dte { get; set; }
        public string marine_safety_office_nm { get; set; }
        public string address_txt { get; set; }
        public string email_address_txt { get; set; }
        public string telephone_nbr { get; set; }
        public string fax_nbr { get; set; }
        public string vessel_nm { get; set; }
        public string former_vessel_nm { get; set; }
        public string official_nbr { get; set; }
        public string inspection_dte { get; set; }
        public Nullable<System.DateTime> date_checkout_dte { get; set; }
        public string file_number { get; set; }
        public Nullable<System.DateTime> date_last_sync_dte { get; set; }
        public string place_of_inspection { get; set; }
    }
    public class mv302_inspection_profileConfiguration : EntityTypeConfiguration<mv302_inspection_profile>
    {
        public mv302_inspection_profileConfiguration()
        {
            this.ToTable("SIRS.mv302_inspection_profile");
            this.HasKey(s => s.inspection_id);
            this.Property(e => e.inspection_id);
            this.Property(e => e.document_nbr);
            this.Property(e => e.inspector_nm);
            this.Property(e => e.inspector_signature_dte);
            this.Property(e => e.representative_nm);
            this.Property(e => e.representative_signature_dte);
            this.Property(e => e.marine_safety_office_nm);
            this.Property(e => e.address_txt);
            this.Property(e => e.email_address_txt);
            this.Property(e => e.telephone_nbr);
            this.Property(e => e.fax_nbr);
            this.Property(e => e.vessel_nm);
            this.Property(e => e.former_vessel_nm);
            this.Property(e => e.official_nbr);
            this.Property(e => e.inspection_dte);
            this.Property(e => e.date_checkout_dte);
            this.Property(e => e.file_number);
            this.Property(e => e.date_last_sync_dte);
            this.Property(e => e.place_of_inspection);
        }
    }


}
