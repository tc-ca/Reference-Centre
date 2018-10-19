namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM002_DEFICIENCY_CODE
    {
        public TM002_DEFICIENCY_CODE()
        {
            this.TM003_XREF_CODE_OBSERVATION = new HashSet<TM003_XREF_CODE_OBSERVATION>();
            this.TM012_XREF_CODE_REFERENCE = new HashSet<TM012_XREF_CODE_REFERENCE>();
            this.YM001_INSP_DEFICIENCY = new HashSet<YM001_INSP_DEFICIENCY>();
        }
    
        public string DEFICIENCY_CODE_CD { get; set; }
        public string DEFICIENCY_CATEGORY_CD { get; set; }
        public string DEFICIENCY_CODE_ETXT { get; set; }
        public string DEFICIENCY_CODE_FTXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
        public Nullable<int> DEFAULT_CORRECTIVE_ACTION_CD { get; set; }
        public Nullable<int> REGULATORY_REFERENCE_CD { get; set; }
    
        public virtual TM001_DEFICIENCY_CATEGORY TM001_DEFICIENCY_CATEGORY { get; set; }
        public virtual TM004_REGULATORY_REFERENCE TM004_REGULATORY_REFERENCE { get; set; }
        public virtual TM006_CORRECTIVE_ACTION TM006_CORRECTIVE_ACTION { get; set; }
        public virtual ICollection<TM003_XREF_CODE_OBSERVATION> TM003_XREF_CODE_OBSERVATION { get; set; }
        public virtual ICollection<TM012_XREF_CODE_REFERENCE> TM012_XREF_CODE_REFERENCE { get; set; }
        public virtual ICollection<YM001_INSP_DEFICIENCY> YM001_INSP_DEFICIENCY { get; set; }
    }
    public class TM002_DEFICIENCY_CODEConfiguration : EntityTypeConfiguration<TM002_DEFICIENCY_CODE>
    {
        public TM002_DEFICIENCY_CODEConfiguration()
        {
            this.ToTable("SIRS.TM002_DEFICIENCY_CODE");
            this.HasKey(s => s.DEFICIENCY_CODE_CD);
            this.HasMany(m => m.TM003_XREF_CODE_OBSERVATION).WithRequired(s => s.TM002_DEFICIENCY_CODE);
            this.HasMany(m => m.TM012_XREF_CODE_REFERENCE).WithRequired(s => s.TM002_DEFICIENCY_CODE);
            this.HasMany(m => m.YM001_INSP_DEFICIENCY).WithRequired(s => s.TM002_DEFICIENCY_CODE);
            this.Property(e => e.DEFICIENCY_CODE_CD);                 
            this.Property(e => e.DEFICIENCY_CATEGORY_CD);             
            this.Property(e => e.DEFICIENCY_CODE_ETXT);               
            this.Property(e => e.DEFICIENCY_CODE_FTXT);               
            this.Property(e => e.DATE_CREATED_DTE);                   
            this.Property(e => e.DATE_DELETED_DTE);                   
            this.Property(e => e.DATE_LAST_UPDATE_DTE);               
            this.Property(e => e.USER_LAST_UPDATE_ID);                
            this.Property(e => e.DEFAULT_CORRECTIVE_ACTION_CD);       
            this.Property(e => e.REGULATORY_REFERENCE_CD);                                          
        }
    }


}
