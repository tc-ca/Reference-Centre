//------------------------------------------------------------------------------
namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class vw302_inspection_profile
    {
        public decimal inspection_id { get; set; }
        public DateTime date_checkout_dte { get; set; }
        public string document_nbr { get; set; }
        public string vessel_nm { get; set; }
        public string former_vessel_nm { get; set; }
        public decimal? official_nbr { get; set; }
        public DateTime? inspection_dte { get; set; }
        public decimal? file_number { get; set; }
        public string date_last_sync_dte { get; set; }
        public string inspector_nm { get; set; }
        public string representative_nm { get; set; }
        public string marine_safety_office_nm { get; set; }
        public string address_txt { get; set; }
        public string email_address_txt { get; set; }
        public string place_of_inspection { get; set; }
        public decimal? telephone_nbr { get; set; }
        public decimal? fax_nbr { get; set; }

    }
    public class vw302_inspection_profileConfiguration : EntityTypeConfiguration<vw302_inspection_profile>
    {
        public vw302_inspection_profileConfiguration()
        {
            this.ToTable("SIRS.vw302_inspection_profile");
            this.HasKey(s => s.inspection_id);
            this.Property(e => e.date_checkout_dte);
            this.Property(e => e.inspection_id);
            this.Property(e => e.date_checkout_dte);
            this.Property(e => e.document_nbr);
            this.Property(e => e.vessel_nm);
            this.Property(e => e.former_vessel_nm);
            this.Property(e => e.official_nbr);
            this.Property(e => e.inspection_dte);
            this.Property(e => e.file_number);
            this.Property(e => e.date_last_sync_dte);
            this.Property(e => e.inspector_nm);
            this.Property(e => e.representative_nm);
            this.Property(e => e.marine_safety_office_nm);
            this.Property(e => e.address_txt);
            this.Property(e => e.email_address_txt);
            this.Property(e => e.place_of_inspection);
            this.Property(e => e.telephone_nbr);
            this.Property(e => e.fax_nbr);

        }
    }
}
