namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM006_CORRECTIVE_ACTION
    {
        public TM006_CORRECTIVE_ACTION()
        {
            this.TM002_DEFICIENCY_CODE = new HashSet<TM002_DEFICIENCY_CODE>();
            this.YM003_DEF_ENFORCEMENT = new HashSet<YM003_DEF_ENFORCEMENT>();
        }
    
        public int CORRECTIVE_ACTION_CD { get; set; }
        public string CORRECTIVE_ACTION_ETXT { get; set; }
        public string CORRECTIVE_ACTION_FTXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual ICollection<TM002_DEFICIENCY_CODE> TM002_DEFICIENCY_CODE { get; set; }
        public virtual ICollection<YM003_DEF_ENFORCEMENT> YM003_DEF_ENFORCEMENT { get; set; }
    }
    public class TM006_CORRECTIVE_ACTIONConfiguration : EntityTypeConfiguration<TM006_CORRECTIVE_ACTION>
    {
        public TM006_CORRECTIVE_ACTIONConfiguration()
        {
            this.ToTable("SIRS.TM006_CORRECTIVE_ACTION");
            this.HasKey(s => s.CORRECTIVE_ACTION_CD);
            this.HasMany(m => m.TM002_DEFICIENCY_CODE).WithOptional(s => s.TM006_CORRECTIVE_ACTION).HasForeignKey(s => s.DEFAULT_CORRECTIVE_ACTION_CD);
            this.HasMany(m => m.YM003_DEF_ENFORCEMENT).WithRequired(s => s.TM006_CORRECTIVE_ACTION);
            this.Property(e => e.CORRECTIVE_ACTION_CD);                  
            this.Property(e => e.CORRECTIVE_ACTION_ETXT);                
            this.Property(e => e.CORRECTIVE_ACTION_FTXT);                
            this.Property(e => e.DATE_CREATED_DTE);                     
            this.Property(e => e.DATE_DELETED_DTE);                     
            this.Property(e => e.DATE_LAST_UPDATE_DTE);                  
            this.Property(e => e.USER_LAST_UPDATE_ID);                                              
        }
    }


}
