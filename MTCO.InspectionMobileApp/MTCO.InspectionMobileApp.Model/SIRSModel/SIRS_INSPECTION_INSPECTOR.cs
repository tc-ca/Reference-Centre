namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class SIRS_INSPECTION_INSPECTOR
    {
        public int INSPECTION_INSPECTOR_ID { get; set; }
        public Nullable<int> INSPECTION_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public string INSPECTION_USER_TYPE { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
    }
    public class SIRS_INSPECTION_INSPECTORConfiguration : EntityTypeConfiguration<SIRS_INSPECTION_INSPECTOR>
    {
        public SIRS_INSPECTION_INSPECTORConfiguration()
        {
            this.ToTable("SIRS.SIRS_INSPECTION_INSPECTOR");
            this.HasKey(s => s.INSPECTION_INSPECTOR_ID);
            this.Property(e => e.INSPECTION_INSPECTOR_ID);    
            this.Property(e => e.INSPECTION_ID);              
            this.Property(e => e.USER_ID);                    
            this.Property(e => e.INSPECTION_USER_TYPE);       
            this.Property(e => e.DATE_CREATED);               
            this.Property(e => e.CREATED_BY);                 
            this.Property(e => e.DATE_MODIFIED);              
            this.Property(e => e.MODIFIED_BY);                                                     
        }
    }


}
