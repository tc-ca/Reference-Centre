namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM010_DEFICIENCY_GROUP
    {
        public TM010_DEFICIENCY_GROUP()
        {
            this.TM001_DEFICIENCY_CATEGORY = new HashSet<TM001_DEFICIENCY_CATEGORY>();
        }
    
        public int DEFICIENCY_GROUP_CD { get; set; }
        public string DEFICIENCY_GROUP_ETXT { get; set; }
        public string DEFICIENCY_GROUP_FTXT { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual ICollection<TM001_DEFICIENCY_CATEGORY> TM001_DEFICIENCY_CATEGORY { get; set; }
    }
    public class TM010_DEFICIENCY_GROUPConfiguration : EntityTypeConfiguration<TM010_DEFICIENCY_GROUP>
    {
        public TM010_DEFICIENCY_GROUPConfiguration()
        {
            this.ToTable("SIRS.TM010_DEFICIENCY_GROUP");
            this.HasKey(s => s.DEFICIENCY_GROUP_CD);
            this.HasMany(m => m.TM001_DEFICIENCY_CATEGORY).WithOptional(s => s.TM010_DEFICIENCY_GROUP);
            this.Property(e => e.DEFICIENCY_GROUP_CD);                
            this.Property(e => e.DEFICIENCY_GROUP_ETXT);              
            this.Property(e => e.DEFICIENCY_GROUP_FTXT);              
            this.Property(e => e.DATE_CREATED_DTE);                   
            this.Property(e => e.DATE_DELETED_DTE);                   
            this.Property(e => e.DATE_LAST_UPDATE_DTE);               
            this.Property(e => e.USER_LAST_UPDATE_ID);                                         
        }
    }



}
