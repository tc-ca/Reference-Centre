namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class YM001_INSP_DEFICIENCY
    {
        public YM001_INSP_DEFICIENCY()
        {
            this.YM003_DEF_ENFORCEMENT = new HashSet<YM003_DEF_ENFORCEMENT>();
            this.YM008_DEF_OBSERVATION = new HashSet<YM008_DEF_OBSERVATION>();
        }

        public string DEFICIENCY_CODE_CD { get; set; }
        public int INSPECTION_ID { get; set; }
        public string DETAIL_TXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
        public string HISTORY_TXT { get; set; }
        public Nullable<System.DateTime> TC_CLOSED_DTE { get; set; }
        public Nullable<int> TC_CLOSED_USER_ID { get; set; }
        public Nullable<System.DateTime> DATE_COMPLIANCE_DTE { get; set; }
        public Nullable<System.DateTime> AR_CLOSED_DTE { get; set; }
        public Nullable<System.DateTime> RO_CLOSED_DTE { get; set; }
        public Nullable<int> INSPECTOR_USER_ID { get; set; }
        public Nullable<System.DateTime> DATE_EXTENDED_COMPLIANCE_DTE { get; set; }
        public Nullable<int> OBSERVATION_CD { get; set; }
        public System.DateTime DATE_DEF_CREATED_DTE { get; set; }
        public string REGULATION_TXT { get; set; }
        public virtual SIRS_INSPECTION SIRS_INSPECTION { get; set; }
        public virtual TM002_DEFICIENCY_CODE TM002_DEFICIENCY_CODE { get; set; }
        public virtual TM005_OBSERVATION TM005_OBSERVATION { get; set; }
        public virtual ICollection<YM003_DEF_ENFORCEMENT> YM003_DEF_ENFORCEMENT { get; set; }
        public virtual ICollection<YM008_DEF_OBSERVATION> YM008_DEF_OBSERVATION { get; set; }
    }
    public class YM001_INSP_DEFICIENCYConfiguration : EntityTypeConfiguration<YM001_INSP_DEFICIENCY>
    {
        public YM001_INSP_DEFICIENCYConfiguration()
        {
            this.ToTable("SIRS.YM001_INSP_DEFICIENCY");
            this.HasKey(s => new { s.DEFICIENCY_CODE_CD, s.INSPECTION_ID, s.DATE_DEF_CREATED_DTE });
            this.HasMany(m => m.YM003_DEF_ENFORCEMENT).WithRequired(s => s.YM001_INSP_DEFICIENCY);
            this.HasMany(m => m.YM008_DEF_OBSERVATION).WithRequired(s => s.YM001_INSP_DEFICIENCY);
            this.Property(e => e.DEFICIENCY_CODE_CD);           
            this.Property(e => e.INSPECTION_ID);                
            this.Property(e => e.DETAIL_TXT);                   
            this.Property(e => e.DATE_CREATED_DTE);             
            this.Property(e => e.DATE_DELETED_DTE);             
            this.Property(e => e.DATE_LAST_UPDATE_DTE);         
            this.Property(e => e.USER_LAST_UPDATE_ID);          
            this.Property(e => e.HISTORY_TXT);                  
            this.Property(e => e.TC_CLOSED_DTE);                
            this.Property(e => e.TC_CLOSED_USER_ID);            
            this.Property(e => e.DATE_COMPLIANCE_DTE);          
            this.Property(e => e.AR_CLOSED_DTE);                
            this.Property(e => e.RO_CLOSED_DTE);                
            this.Property(e => e.INSPECTOR_USER_ID);            
            this.Property(e => e.DATE_EXTENDED_COMPLIANCE_DTE); 
            this.Property(e => e.OBSERVATION_CD);               
            this.Property(e => e.DATE_DEF_CREATED_DTE);         
            this.Property(e => e.REGULATION_TXT);                                    
        }
    }



}
