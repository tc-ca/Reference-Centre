namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class YM003_DEF_ENFORCEMENT
    {
        public int CORRECTIVE_ACTION_CD { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
        public string DEFICIENCY_CODE_CD { get; set; }
        public int INSPECTION_ID { get; set; }
        public System.DateTime DATE_DEF_CREATED_DTE { get; set; }

        public virtual TM006_CORRECTIVE_ACTION TM006_CORRECTIVE_ACTION { get; set; }
        public virtual YM001_INSP_DEFICIENCY YM001_INSP_DEFICIENCY { get; set; }
    }
    public class YM003_DEF_ENFORCEMENTConfiguration : EntityTypeConfiguration<YM003_DEF_ENFORCEMENT>
    {
        public YM003_DEF_ENFORCEMENTConfiguration()
        {
            this.ToTable("SIRS.YM003_DEF_ENFORCEMENT");
            this.HasKey(s => new { s.CORRECTIVE_ACTION_CD, s.DEFICIENCY_CODE_CD, s.INSPECTION_ID, s.DATE_DEF_CREATED_DTE });
            this.Property(e => e.CORRECTIVE_ACTION_CD);             
            this.Property(e => e.DATE_CREATED_DTE);                 
            this.Property(e => e.DATE_DELETED_DTE);                 
            this.Property(e => e.DATE_LAST_UPDATE_DTE);             
            this.Property(e => e.USER_LAST_UPDATE_ID);              
            this.Property(e => e.DEFICIENCY_CODE_CD);               
            this.Property(e => e.INSPECTION_ID);                    
            this.Property(e => e.DATE_DEF_CREATED_DTE);                             
        }
    }


}
