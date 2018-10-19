namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class SIRS_INSPECTION
    {
        public SIRS_INSPECTION()
        {
            this.YM001_INSP_DEFICIENCY = new HashSet<YM001_INSP_DEFICIENCY>();
        }

        public int INSPECTION_ID { get; set; }
        public string INSPECTION_TYPE { get; set; }
        public Nullable<int> FILE_NO { get; set; }
        public string INSPECTION_STATUS { get; set; }
        public string DISTRICT_OFFICE { get; set; }
        public string REGIONAL_APPROVAL_FLAG { get; set; }
        public string DISTRICT_APPROVAL_FLAG { get; set; }
        public Nullable<System.DateTime> INSPECTION_DATE { get; set; }
        public string PLACE_OF_INSPECTION { get; set; }
        public string DEFICIENCIES_NOTED_FLAG { get; set; }
        public Nullable<int> PRE_INSP_REPORT_ID { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public string COMMENTS { get; set; }
        public string DELEGATED_TO_CLASS_TEMP { get; set; }
        public string CLC_PARTII_APPLIES { get; set; }
        public string CLC_PARTII_INSPECTION_IND { get; set; }
        public string MODS_SINCE_LAST_INSP_IND { get; set; }
        public Nullable<System.DateTime> RO_LAST_INSPECTION_DTE { get; set; }
        public string SERVICE_REQUEST_CD { get; set; }

        public virtual ICollection<YM001_INSP_DEFICIENCY> YM001_INSP_DEFICIENCY { get; set; }
    }

    public class SIRS_INSPECTIONConfiguration : EntityTypeConfiguration<SIRS_INSPECTION>
    {
        public SIRS_INSPECTIONConfiguration()
        {
            this.ToTable("SIRS.SIRS_INSPECTION");
            this.HasKey(s => s.INSPECTION_ID);
            this.HasMany(m => m.YM001_INSP_DEFICIENCY).WithRequired(s => s.SIRS_INSPECTION);
            this.Property(e => e.INSPECTION_ID);            
            this.Property(e => e.INSPECTION_TYPE);          
            this.Property(e => e.FILE_NO);                  
            this.Property(e => e.INSPECTION_STATUS);        
            this.Property(e => e.DISTRICT_OFFICE);          
            this.Property(e => e.REGIONAL_APPROVAL_FLAG);   
            this.Property(e => e.DISTRICT_APPROVAL_FLAG);   
            this.Property(e => e.INSPECTION_DATE);          
            this.Property(e => e.PLACE_OF_INSPECTION);      
            this.Property(e => e.DEFICIENCIES_NOTED_FLAG);  
            this.Property(e => e.PRE_INSP_REPORT_ID);       
            this.Property(e => e.DATE_CREATED);             
            this.Property(e => e.CREATED_BY);               
            this.Property(e => e.DATE_MODIFIED);            
            this.Property(e => e.MODIFIED_BY);              
            this.Property(e => e.COMMENTS);                 
            this.Property(e => e.DELEGATED_TO_CLASS_TEMP);  
            this.Property(e => e.CLC_PARTII_APPLIES);       
            this.Property(e => e.CLC_PARTII_INSPECTION_IND);
            this.Property(e => e.MODS_SINCE_LAST_INSP_IND); 
            this.Property(e => e.RO_LAST_INSPECTION_DTE);   
            this.Property(e => e.SERVICE_REQUEST_CD);                    
        }
    }



}
