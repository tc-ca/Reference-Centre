namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty205_template_item_type
    {
       public ty205_template_item_type()
        {
            this.ty206_template_item = new HashSet<ty206_template_item>();
        }
    
        public long template_item_type_cd { get; set; }
        public string template_item_type_elbl { get; set; }
        public string template_item_type_flbl { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
           public virtual ICollection<ty206_template_item> ty206_template_item { get; set; }
    }
    public class ty205_template_item_typeConfiguration : EntityTypeConfiguration<ty205_template_item_type>
    {
        public ty205_template_item_typeConfiguration()
        {
            this.ToTable("SIRS.ty205_template_item_type");
            this.HasKey(s => s.template_item_type_cd);
            this.HasMany(m => m.ty206_template_item).WithRequired(s => s.ty205_template_item_type);
            this.Property(e => e.template_item_type_cd);
            this.Property(e => e.template_item_type_elbl);
            this.Property(e => e.template_item_type_flbl);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
