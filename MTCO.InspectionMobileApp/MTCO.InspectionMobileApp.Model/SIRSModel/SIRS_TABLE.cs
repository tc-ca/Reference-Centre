namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class  SIRS_TABLE
    {
        public int TABLE_ID { get; set; }
        public Nullable<short> TABLE_NO { get; set; }
        public string TABLE_CODE { get; set; }
        public Nullable<int> PARENT_TABLE_ID { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public string DESC_E { get; set; }
        public string DESC_F { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public string IS_DEFAULT { get; set; }
    }
    public class SIRS_TABLEConfiguration : EntityTypeConfiguration<SIRS_TABLE>
    {
        public SIRS_TABLEConfiguration()
        {
            this.ToTable("SIRS.SIRS_TABLE");
            this.HasKey(s => s.TABLE_ID);
            this.Property(e => e.TABLE_ID);                   
            this.Property(e => e.TABLE_NO);                   
            this.Property(e => e.TABLE_CODE);                 
            this.Property(e => e.PARENT_TABLE_ID);            
            this.Property(e => e.ACTIVE_FLAG);                
            this.Property(e => e.DESC_E);                     
            this.Property(e => e.DESC_F);                     
            this.Property(e => e.DATE_CREATED);               
            this.Property(e => e.CREATED_BY);                 
            this.Property(e => e.DATE_MODIFIED);              
            this.Property(e => e.MODIFIED_BY);                
            this.Property(e => e.IS_DEFAULT);                 
        }                                                                                                                             
    }


}
