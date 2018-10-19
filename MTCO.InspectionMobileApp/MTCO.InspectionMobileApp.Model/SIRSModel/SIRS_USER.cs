namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class SIRS_USER
    {
        public int USER_ID { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string USER_INITIALS { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public string DISTRICT_OFFICE { get; set; }
        public string DEFAULT_USER_ROLE { get; set; }
        public string USER_STATUS { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public string USER_SYSTEM { get; set; }
        public Nullable<int> REPORTING_UNIT_ID { get; set; }
    }
    public class SIRS_USERConfiguration : EntityTypeConfiguration<SIRS_USER>
    {
        public SIRS_USERConfiguration()
        {
            this.ToTable("SIRS.SIRS_USER");
            this.HasKey(s => s.USER_ID);
            this.Property(e => e.USER_ID);                 
            this.Property(e => e.LAST_NAME);               
            this.Property(e => e.FIRST_NAME);              
            this.Property(e => e.USER_INITIALS);           
            this.Property(e => e.USER_NAME);               
            this.Property(e => e.USER_PASSWORD);           
            this.Property(e => e.EMAIL_ADDRESS);           
            this.Property(e => e.DISTRICT_OFFICE);         
            this.Property(e => e.DEFAULT_USER_ROLE);       
            this.Property(e => e.USER_STATUS);             
            this.Property(e => e.DATE_CREATED);            
            this.Property(e => e.CREATED_BY);              
            this.Property(e => e.DATE_MODIFIED);           
            this.Property(e => e.MODIFIED_BY);             
            this.Property(e => e.USER_SYSTEM);             
            this.Property(e => e.REPORTING_UNIT_ID);                              
        }
    }


}
