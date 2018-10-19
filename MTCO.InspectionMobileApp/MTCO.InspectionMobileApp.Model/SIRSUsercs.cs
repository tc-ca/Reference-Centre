namespace MTCO.InspectionMobileApp.Model
{
    using System;
    using System.Collections.Generic;

    public partial class SIRSUser
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
}
