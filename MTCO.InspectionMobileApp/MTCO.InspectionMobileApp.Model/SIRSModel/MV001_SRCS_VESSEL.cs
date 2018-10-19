namespace MTCO.InspectionMobileApp.Model.SIRSModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public class MV001_SRCS_VESSEL
    {
        public int OFFICIAL_ID { get; set; }
        public Nullable<int> YEAR_BUILD_NUM { get; set; }
        public string ALL_OWNERS_TXT { get; set; }
        public string VESSEL_TYPE_DESCRIPTOR_CD { get; set; }
        public string VESSEL_TYPE_DESCRIPTOR_ETXT { get; set; }
        public string VESSEL_TYPE_DESCRIPTOR_FTXT { get; set; }
        public string VESSEL_TYPE_PRIMARY_CD { get; set; }
        public string VESSEL_TYPE_PRIMARY_ETXT { get; set; }
        public string VESSEL_TYPE_PRIMARY_FTXT { get; set; }
        public string VESSEL_TYPE_SECONDARY_CD { get; set; }
        public string VESSEL_TYPE_SECONDARY_ETXT { get; set; }
        public string VESSEL_TYPE_SECONDARY_FTXT { get; set; }
        public string CONSTRUCTION_MATERIAL_CD { get; set; }
        public string CONSTRUCTION_MATERIAL_ETXT { get; set; }
        public string CONSTRUCTION_MATERIAL_FTXT { get; set; }
        public Nullable<int> MEASURE_LENGTH_NBR { get; set; }
        public Nullable<int> MEASURE_BREADTH_NBR { get; set; }
        public Nullable<int> MEASURE_DEPTH_NBR { get; set; }
        public string VESSEL_NAME_NM { get; set; }
        public Nullable<System.DateTime> DATE_REGISTRATION_EXPIRY_DTE { get; set; }
        public string BUILDER_PARTY_NM { get; set; }
        public string HULL_NBR { get; set; }
        public Nullable<int> TONNAGE_GROSS_NBR { get; set; }
        public Nullable<int> TONNAGE_REGISTERED_NBR { get; set; }
        public Nullable<int> YEAR_REBUILD_NBR { get; set; }
        public string PORT_OF_REGISTRY_CD { get; set; }
        public string PORT_OF_REGISTRY_ETXT { get; set; }
        public string PORT_OF_REGISTRY_FTXT { get; set; }
        public Nullable<System.DateTime> DATE_REGISTRATION_DTE { get; set; }
        public Nullable<int> PROPULSION_POWER_NBR { get; set; }
        public string IMO_SHIP_ID { get; set; }
        public string FORMER_VESSEL_NM { get; set; }
        public string SOURCE_SYSTEM_TXT { get; set; }
    }


    public class MV001_SRCS_VESSELConfiguration : EntityTypeConfiguration<MV001_SRCS_VESSEL>
    {
        public MV001_SRCS_VESSELConfiguration()
        {
            this.ToTable("SIRS.MV001_SRCS_VESSEL");
            this.HasKey(s => s.OFFICIAL_ID);
            this.Property(e => e.OFFICIAL_ID);                    
            this.Property(e => e.YEAR_BUILD_NUM);                 
            this.Property(e => e.ALL_OWNERS_TXT);                 
            this.Property(e => e.VESSEL_TYPE_DESCRIPTOR_CD);      
            this.Property(e => e.VESSEL_TYPE_DESCRIPTOR_ETXT);    
            this.Property(e => e.VESSEL_TYPE_DESCRIPTOR_FTXT);    
            this.Property(e => e.VESSEL_TYPE_PRIMARY_CD);         
            this.Property(e => e.VESSEL_TYPE_PRIMARY_ETXT);       
            this.Property(e => e.VESSEL_TYPE_PRIMARY_FTXT);       
            this.Property(e => e.VESSEL_TYPE_SECONDARY_CD);       
            this.Property(e => e.VESSEL_TYPE_SECONDARY_ETXT);     
            this.Property(e => e.VESSEL_TYPE_SECONDARY_FTXT);     
            this.Property(e => e.CONSTRUCTION_MATERIAL_CD);       
            this.Property(e => e.CONSTRUCTION_MATERIAL_ETXT);     
            this.Property(e => e.CONSTRUCTION_MATERIAL_FTXT);     
            this.Property(e => e.MEASURE_LENGTH_NBR);             
            this.Property(e => e.MEASURE_BREADTH_NBR);            
            this.Property(e => e.MEASURE_DEPTH_NBR);              
            this.Property(e => e.VESSEL_NAME_NM);                 
            this.Property(e => e.DATE_REGISTRATION_EXPIRY_DTE);   
            this.Property(e => e.BUILDER_PARTY_NM);                                     
            this.Property(e => e.HULL_NBR);                    
            this.Property(e => e.TONNAGE_GROSS_NBR);           
            this.Property(e => e.TONNAGE_REGISTERED_NBR);      
            this.Property(e => e.YEAR_REBUILD_NBR);            
            this.Property(e => e.PORT_OF_REGISTRY_CD);         
            this.Property(e => e.PORT_OF_REGISTRY_ETXT);       
            this.Property(e => e.PORT_OF_REGISTRY_FTXT);       
            this.Property(e => e.DATE_REGISTRATION_DTE);       
            this.Property(e => e.PROPULSION_POWER_NBR);        
            this.Property(e => e.IMO_SHIP_ID);                 
            this.Property(e => e.FORMER_VESSEL_NM);            
            this.Property(e => e.SOURCE_SYSTEM_TXT);           
        }
    }                                                                                                                                                         

}
