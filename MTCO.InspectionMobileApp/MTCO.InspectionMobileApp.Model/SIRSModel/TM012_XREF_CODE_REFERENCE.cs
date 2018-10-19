namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM012_XREF_CODE_REFERENCE
    {
        public string PROGRAM_CD { get; set; }
        public string DEFICIENCY_CODE_CD { get; set; }
        public int REGULATORY_REFERENCE_CD { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }

        public virtual TM002_DEFICIENCY_CODE TM002_DEFICIENCY_CODE { get; set; }
        public virtual TM004_REGULATORY_REFERENCE TM004_REGULATORY_REFERENCE { get; set; }
    }
    public class TM012_XREF_CODE_REFERENCEConfiguration : EntityTypeConfiguration<TM012_XREF_CODE_REFERENCE>
    {
        public TM012_XREF_CODE_REFERENCEConfiguration()
        {
            this.ToTable("SIRS.TM012_XREF_CODE_REFERENCE");
            this.HasKey(s => new { s.PROGRAM_CD, s.DEFICIENCY_CODE_CD, s.REGULATORY_REFERENCE_CD });
            this.Property(e => e.PROGRAM_CD);
            this.Property(e => e.DEFICIENCY_CODE_CD);
            this.Property(e => e.REGULATORY_REFERENCE_CD);
            this.Property(e => e.DATE_CREATED_DTE);
            this.Property(e => e.DATE_DELETED_DTE);
            this.Property(e => e.DATE_LAST_UPDATE_DTE);
            this.Property(e => e.USER_LAST_UPDATE_ID);
        }
    }


}
