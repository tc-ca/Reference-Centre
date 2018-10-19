namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM001_DEFICIENCY_CATEGORY
    {
        public TM001_DEFICIENCY_CATEGORY()
        {
            this.TM002_DEFICIENCY_CODE = new HashSet<TM002_DEFICIENCY_CODE>();
        }
    
        public string DEFICIENCY_CATEGORY_CD { get; set; }
        public string DEFICIENCY_CATEGORY_ETXT { get; set; }
        public string DEFICIENCY_CATEGORY_FTXT { get; set; }
        public Nullable<int> DEFICIENCY_GROUP_CD { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual TM010_DEFICIENCY_GROUP TM010_DEFICIENCY_GROUP { get; set; }
        public virtual ICollection<TM002_DEFICIENCY_CODE> TM002_DEFICIENCY_CODE { get; set; }
    }
    public class TM001_DEFICIENCY_CATEGORYConfiguration : EntityTypeConfiguration<TM001_DEFICIENCY_CATEGORY>
    {
        public TM001_DEFICIENCY_CATEGORYConfiguration()
        {
            this.ToTable("SIRS.TM001_DEFICIENCY_CATEGORY");
            this.HasKey(s => s.DEFICIENCY_CATEGORY_CD);
            this.HasMany(m => m.TM002_DEFICIENCY_CODE).WithOptional(s => s.TM001_DEFICIENCY_CATEGORY);
            this.Property(e => e.DEFICIENCY_CATEGORY_CD);               
            this.Property(e => e.DEFICIENCY_CATEGORY_ETXT);             
            this.Property(e => e.DEFICIENCY_CATEGORY_FTXT);             
            this.Property(e => e.DEFICIENCY_GROUP_CD);                  
            this.Property(e => e.DATE_CREATED_DTE);                     
            this.Property(e => e.DATE_DELETED_DTE);                     
            this.Property(e => e.DATE_LAST_UPDATE_DTE);                 
            this.Property(e => e.USER_LAST_UPDATE_ID);                                                 
        }
    }



}
