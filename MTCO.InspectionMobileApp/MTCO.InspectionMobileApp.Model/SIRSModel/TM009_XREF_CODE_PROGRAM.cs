namespace MTCO.InspectionMobileApp.DAL.Server.SIRSModel
{
    using MTCO.InspectionMobileApp.Model.SIRSModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    public class TM009_XREF_CODE_PROGRAM
    {
        public string PROGRAM_CD { get; set; }
        public string DEFICIENCY_CODE_CD { get; set; }
        public System.DateTime DATE_CREATED_DTE { get; set; }
        public Nullable<System.DateTime> DATE_DELETED_DTE { get; set; }
        public System.DateTime DATE_LAST_UPDATE_DTE { get; set; }
        public int USER_LAST_UPDATE_ID { get; set; }
    
        public virtual TM002_DEFICIENCY_CODE TM002_DEFICIENCY_CODE { get; set; }
    }
    public class TM009_XREF_CODE_PROGRAMConfiguration : EntityTypeConfiguration<TM009_XREF_CODE_PROGRAM>
    {
        public TM009_XREF_CODE_PROGRAMConfiguration()
        {
            this.ToTable("SIRS.TM009_XREF_CODE_PROGRAM");
            this.HasKey(s => new { s.PROGRAM_CD, s.DEFICIENCY_CODE_CD });
            this.Property(e => e.PROGRAM_CD);                    
            this.Property(e => e.DEFICIENCY_CODE_CD);            
            this.Property(e => e.DATE_CREATED_DTE);              
            this.Property(e => e.DATE_DELETED_DTE);              
            this.Property(e => e.DATE_LAST_UPDATE_DTE);          
            this.Property(e => e.USER_LAST_UPDATE_ID);                             
        }
    }


}
