
namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty203_template_form
    {
        public ty203_template_form()
        {
            this.ty204_template_group = new HashSet<ty204_template_group>();
        }
    
        public long template_form_cd { get; set; }
        public long template_type_cd { get; set; }
        public string template_form_enm { get; set; }
        public string template_form_fnm { get; set; }
        public long dynamic_template_form_ind { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual ty202_template_type ty202_template_type { get; set; }
        public virtual ICollection<ty204_template_group> ty204_template_group { get; set; }
    }
    public class ty203_template_formConfiguration : EntityTypeConfiguration<ty203_template_form>
    {
        public ty203_template_formConfiguration()
        {
            this.ToTable("SIRS.ty203_template_form");
            this.HasKey(s => s.template_form_cd);
            this.HasMany(m => m.ty204_template_group).WithRequired(s => s.ty203_template_form);
            this.Property(e => e.template_form_cd);
            this.Property(e => e.template_type_cd);
            this.Property(e => e.template_form_enm);
            this.Property(e => e.template_form_fnm);
            this.Property(e => e.dynamic_template_form_ind);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
