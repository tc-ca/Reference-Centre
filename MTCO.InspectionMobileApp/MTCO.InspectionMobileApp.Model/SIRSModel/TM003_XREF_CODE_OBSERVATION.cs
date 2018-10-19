namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM003_XREF_CODE_OBSERVATION
    {
        public int OBSERVATION_CD { get; set; }
        public string DEFICIENCY_CODE_CD { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual TM002_DEFICIENCY_CODE TM002_DEFICIENCY_CODE { get; set; }
        public virtual TM005_OBSERVATION TM005_OBSERVATION { get; set; }
    }
    public class TM003_XREF_CODE_OBSERVATIONConfiguration : EntityTypeConfiguration<TM003_XREF_CODE_OBSERVATION>
    {
        public TM003_XREF_CODE_OBSERVATIONConfiguration()
        {
            this.ToTable("SIRS.TM003_XREF_CODE_OBSERVATION");
            this.HasKey(s => new { s.OBSERVATION_CD, s.DEFICIENCY_CODE_CD });
            this.Property(e => e.OBSERVATION_CD);                    
            this.Property(e => e.DEFICIENCY_CODE_CD);                
            this.Property(e => e.DATE_CREATED_DTE);                  
            this.Property(e => e.DATE_DELETED_DTE);                  
            this.Property(e => e.DATE_LAST_UPDATE_DTE);              
            this.Property(e => e.USER_LAST_UPDATE_ID);                                
        }
    }


}
