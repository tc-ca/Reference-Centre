namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class SIRS_VESSEL
    {
        public int FILE_NO { get; set; }
        public string VESSEL_STATUS { get; set; }
        public string CURRENT_PREFIX { get; set; }
        public Nullable<int> OFFICIAL_NUMBER { get; set; }
        public Nullable<int> OLD_BUILDER_ID { get; set; }
        public string OTHER_IDENTIFIER_DESC { get; set; }
        public string OTHER_IDENTIFIER_NO { get; set; }
        public string OTHER_IDENTIFIER_TYPE_FLAG { get; set; }
        public string DELEGATED_TO_CLASS { get; set; }
        public string LOCKED_FLAG { get; set; }
        public string DISTRICT_OFFICE { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public string GOV_OPERATED_VESSEL { get; set; }
        public string PA_FILM_MACH { get; set; }
        public string PA_FILM_HULL { get; set; }
        public string PA_FILM_ELECT { get; set; }
        public string PA_PLANS_LOC { get; set; }
        public string PA_STAB_LOC { get; set; }
        public string PA_MICROGRAPH { get; set; }
        public string PA_REMARKS { get; set; }
        public string PROGRAM_CD { get; set; }
        public string COASTING_TRADE_IND { get; set; }
        public string SIRS_ALL_OWNERS_TXT { get; set; }
        public string SIRS_BUILDER_PARTY_NM { get; set; }
        public string SIRS_CONSTRUCTION_MATERIAL_CD { get; set; }
        public Nullable<System.DateTime> SIRS_DATE_REGISTRATION_DTE { get; set; }
        public Nullable<System.DateTime> SIRS_DATE_REGISTRATION_EXP_DTE { get; set; }
        public string SIRS_FORMER_VESSEL_NM { get; set; }
        public string SIRS_HULL_PROJECT_TXT { get; set; }
        public string SIRS_IMO_SHIP_ID { get; set; }
        public Nullable<int> SIRS_MEASURE_BREADTH_NBR { get; set; }
        public Nullable<int> SIRS_MEASURE_DEPTH_NBR { get; set; }
        public Nullable<int> SIRS_MEASURE_LENGTH_NBR { get; set; }
        public string SIRS_PORT_OF_REGISTRY_CD { get; set; }
        public Nullable<int> SIRS_PROPULSION_POWER_NBR { get; set; }
        public Nullable<int> SIRS_TONNAGE_GROSS_NBR { get; set; }
        public Nullable<int> SIRS_TONNAGE_REGISTERED_NBR { get; set; }
        public string SIRS_VESSEL_NAME_NM { get; set; }
        public string SIRS_VESSEL_TYPE_DESCRIPTOR_CD { get; set; }
        public string SIRS_VESSEL_TYPE_PRIMARY_CD { get; set; }
        public string SIRS_VESSEL_TYPE_SECONDARY_CD { get; set; }
        public Nullable<int> SIRS_YEAR_BUILD_NUM { get; set; }
        public Nullable<int> SIRS_YEAR_REBUILD_NBR { get; set; }
    }

    public class SIRS_VESSELConfiguration : EntityTypeConfiguration<SIRS_VESSEL>
    {
        public SIRS_VESSELConfiguration()
        {
            this.ToTable("SIRS.SIRS_VESSEL");
            this.HasKey(s => s.FILE_NO);
            this.Property(e => e.FILE_NO);                     
            this.Property(e => e.VESSEL_STATUS);               
            this.Property(e => e.CURRENT_PREFIX);              
            this.Property(e => e.OFFICIAL_NUMBER);             
            this.Property(e => e.OLD_BUILDER_ID);              
            this.Property(e => e.OTHER_IDENTIFIER_DESC);       
            this.Property(e => e.OTHER_IDENTIFIER_NO);         
            this.Property(e => e.OTHER_IDENTIFIER_TYPE_FLAG); 
            this.Property(e => e.DELEGATED_TO_CLASS);          
            this.Property(e => e.LOCKED_FLAG);                 
            this.Property(e => e.DISTRICT_OFFICE);             
            this.Property(e => e.DATE_CREATED);                
            this.Property(e => e.CREATED_BY);                  
            this.Property(e => e.DATE_MODIFIED);               
            this.Property(e => e.MODIFIED_BY);                 
            this.Property(e => e.GOV_OPERATED_VESSEL);         
            this.Property(e => e.PA_FILM_MACH);                
            this.Property(e => e.PA_FILM_HULL);                
            this.Property(e => e.PA_FILM_ELECT);               
            this.Property(e => e.PA_PLANS_LOC);                
            this.Property(e => e.PA_STAB_LOC);                 
            this.Property(e => e.PA_MICROGRAPH);               
            this.Property(e => e.PA_REMARKS);                  
            this.Property(e => e.PROGRAM_CD);                  
            this.Property(e => e.COASTING_TRADE_IND);          
            this.Property(e => e.SIRS_ALL_OWNERS_TXT);           
            this.Property(e => e.SIRS_BUILDER_PARTY_NM);            
            this.Property(e => e.SIRS_CONSTRUCTION_MATERIAL_CD);    
            this.Property(e => e.SIRS_DATE_REGISTRATION_DTE);       
            this.Property(e => e.SIRS_DATE_REGISTRATION_EXP_DTE);   
            this.Property(e => e.SIRS_FORMER_VESSEL_NM);            
            this.Property(e => e.SIRS_HULL_PROJECT_TXT);            
            this.Property(e => e.SIRS_IMO_SHIP_ID);                 
            this.Property(e => e.SIRS_MEASURE_BREADTH_NBR);         
            this.Property(e => e.SIRS_MEASURE_DEPTH_NBR);           
            this.Property(e => e.SIRS_MEASURE_LENGTH_NBR);          
            this.Property(e => e.SIRS_PORT_OF_REGISTRY_CD);         
            this.Property(e => e.SIRS_PROPULSION_POWER_NBR);        
            this.Property(e => e.SIRS_TONNAGE_GROSS_NBR);           
            this.Property(e => e.SIRS_TONNAGE_REGISTERED_NBR);      
            this.Property(e => e.SIRS_VESSEL_NAME_NM);              
            this.Property(e => e.SIRS_VESSEL_TYPE_DESCRIPTOR_CD);   
            this.Property(e => e.SIRS_VESSEL_TYPE_PRIMARY_CD);      
            this.Property(e => e.SIRS_VESSEL_TYPE_SECONDARY_CD);    
            this.Property(e => e.SIRS_YEAR_BUILD_NUM);              
            this.Property(e => e.SIRS_YEAR_REBUILD_NBR);                             
        }
    }


}
