namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM005_OBSERVATION
    {
        public TM005_OBSERVATION()
        {
            this.TM003_XREF_CODE_OBSERVATION = new HashSet<TM003_XREF_CODE_OBSERVATION>();
            this.YM001_INSP_DEFICIENCY = new HashSet<YM001_INSP_DEFICIENCY>();
            this.YM008_DEF_OBSERVATION = new HashSet<YM008_DEF_OBSERVATION>();
        }
    
        public int OBSERVATION_CD { get; set; }
        public string OBSERVATION_ETXT { get; set; }
        public string OBSERVATION_FTXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual ICollection<TM003_XREF_CODE_OBSERVATION> TM003_XREF_CODE_OBSERVATION { get; set; }
        public virtual ICollection<YM001_INSP_DEFICIENCY> YM001_INSP_DEFICIENCY { get; set; }
        public virtual ICollection<YM008_DEF_OBSERVATION> YM008_DEF_OBSERVATION { get; set; }
    }
    public class TM005_OBSERVATIONConfiguration : EntityTypeConfiguration<TM005_OBSERVATION>
    {
        public TM005_OBSERVATIONConfiguration()
        {
            this.ToTable("SIRS.TM005_OBSERVATION");
            this.HasKey(s => s.OBSERVATION_CD);
            this.HasMany(m => m.TM003_XREF_CODE_OBSERVATION).WithRequired(s => s.TM005_OBSERVATION);
            this.HasMany(m => m.YM001_INSP_DEFICIENCY).WithOptional(s => s.TM005_OBSERVATION);
            this.HasMany(m => m.YM008_DEF_OBSERVATION).WithRequired(s => s.TM005_OBSERVATION);
            this.Property(e => e.OBSERVATION_CD);                  
            this.Property(e => e.OBSERVATION_ETXT);                
            this.Property(e => e.OBSERVATION_FTXT);                
            this.Property(e => e.DATE_CREATED_DTE);                
            this.Property(e => e.DATE_DELETED_DTE);                
            this.Property(e => e.DATE_LAST_UPDATE_DTE);            
            this.Property(e => e.USER_LAST_UPDATE_ID);                           
        }
    }



}
