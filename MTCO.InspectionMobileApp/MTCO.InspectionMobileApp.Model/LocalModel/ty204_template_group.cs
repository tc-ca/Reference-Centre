namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty204_template_group
    {
        public ty204_template_group()
        {
            this.ty206_template_item = new HashSet<ty206_template_item>();
        }
    
        public long template_group_cd { get; set; }
        public Nullable<long> parent_template_group_cd { get; set; }
        public long template_form_cd { get; set; }
        public string template_group_display_txt { get; set; }
        public string template_group_elbl { get; set; }
        public string template_group_flbl { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual ty203_template_form ty203_template_form { get; set; }
        public virtual ICollection<ty206_template_item> ty206_template_item { get; set; }
    }
    public class ty204_template_groupConfiguration : EntityTypeConfiguration<ty204_template_group>
    {
        public ty204_template_groupConfiguration()
        {
            this.ToTable("SIRS.ty204_template_group");
            this.HasKey(s => s.template_group_cd);
            this.HasMany(m => m.ty206_template_item).WithRequired(s => s.ty204_template_group);
            this.Property(e => e.template_group_cd);
            this.Property(e => e.parent_template_group_cd);
            this.Property(e => e.template_form_cd);
            this.Property(e => e.template_group_display_txt);
            this.Property(e => e.template_group_elbl);
            this.Property(e => e.template_group_flbl);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
