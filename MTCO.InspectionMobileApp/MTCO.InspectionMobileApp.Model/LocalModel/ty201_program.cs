//------------------------------------------------------------------------------
namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty201_program
    {
        public ty201_program()
        {
            this.ty202_template_type = new HashSet<ty202_template_type>();
        }
    
        public long program_cd { get; set; }
        public string program_enm { get; set; }
        public string program_fnm { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual ICollection<ty202_template_type> ty202_template_type { get; set; }
    }
    public class ty201_programConfiguration : EntityTypeConfiguration<ty201_program>
    {
        public ty201_programConfiguration()
        {
            this.ToTable("SIRS.ty201_program");
            this.HasKey(s => s.program_cd);
            this.HasMany(m => m.ty202_template_type).WithRequired(s => s.ty201_program);
            this.Property(e => e.program_cd);
            this.Property(e => e.program_enm);
            this.Property(e => e.program_fnm);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
