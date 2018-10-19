namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM004_REGULATORY_REFERENCE
    {
        public TM004_REGULATORY_REFERENCE()
        {
            this.TM002_DEFICIENCY_CODE = new HashSet<TM002_DEFICIENCY_CODE>();
            this.TM012_XREF_CODE_REFERENCE = new HashSet<TM012_XREF_CODE_REFERENCE>();
        }
    
        public int REGULATORY_REFERENCE_CD { get; set; }
        public string REGULATORY_REFERENCE_ETXT { get; set; }
        public string REGULATORY_REFERENCE_FTXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual ICollection<TM002_DEFICIENCY_CODE> TM002_DEFICIENCY_CODE { get; set; }
        public virtual ICollection<TM012_XREF_CODE_REFERENCE> TM012_XREF_CODE_REFERENCE { get; set; }
    }
    public class TM004_REGULATORY_REFERENCEConfiguration : EntityTypeConfiguration<TM004_REGULATORY_REFERENCE>
    {
        public TM004_REGULATORY_REFERENCEConfiguration()
        {
            this.ToTable("SIRS.TM004_REGULATORY_REFERENCE");
            this.HasKey(s => s.REGULATORY_REFERENCE_CD);
            this.HasMany(m => m.TM002_DEFICIENCY_CODE).WithOptional(s => s.TM004_REGULATORY_REFERENCE);
            this.HasMany(m => m.TM012_XREF_CODE_REFERENCE).WithRequired(s => s.TM004_REGULATORY_REFERENCE);
            this.Property(e => e.REGULATORY_REFERENCE_CD);            
            this.Property(e => e.REGULATORY_REFERENCE_ETXT);          
            this.Property(e => e.REGULATORY_REFERENCE_FTXT);          
            this.Property(e => e.DATE_CREATED_DTE);                   
            this.Property(e => e.DATE_DELETED_DTE);                   
            this.Property(e => e.DATE_LAST_UPDATE_DTE);               
            this.Property(e => e.USER_LAST_UPDATE_ID);                                                 
        }
    }



}
