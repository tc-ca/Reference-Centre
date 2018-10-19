namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class YM008_DEF_OBSERVATION
    {
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_LAST_UPDATE_DTE { get; set; }
        public string DEFICIENCY_CODE_CD { get; set; }
        public int INSPECTION_ID { get; set; }
        public int OBSERVATION_CD { get; set; }
        public Nullable<int> USER_LAST_UPDATE_ID { get; set; }
        public System.DateTime DATE_DEF_CREATED_DTE { get; set; }
    
        public virtual TM005_OBSERVATION TM005_OBSERVATION { get; set; }
        public virtual YM001_INSP_DEFICIENCY YM001_INSP_DEFICIENCY { get; set; }
    }
    public class YM008_DEF_OBSERVATIONConfiguration : EntityTypeConfiguration<YM008_DEF_OBSERVATION>
    {
        public YM008_DEF_OBSERVATIONConfiguration()
        {
            this.ToTable("SIRS.YM008_DEF_OBSERVATION");
            this.HasKey(s => new { s.DEFICIENCY_CODE_CD, s.INSPECTION_ID, s.OBSERVATION_CD, s.DATE_DEF_CREATED_DTE });
            this.Property(e => e.DATE_CREATED_DTE);               
            this.Property(e => e.DATE_DELETED_DTE);               
            this.Property(e => e.DATE_LAST_UPDATE_DTE);           
            this.Property(e => e.DEFICIENCY_CODE_CD);             
            this.Property(e => e.INSPECTION_ID);                  
            this.Property(e => e.OBSERVATION_CD);                 
            this.Property(e => e.USER_LAST_UPDATE_ID);            
            this.Property(e => e.DATE_DEF_CREATED_DTE);                           
        }
    }



}
