namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class ty206_template_item
    {
        public ty206_template_item()
        {
            this.cc302_inspection_profile = new HashSet<cc302_inspection_profile>();
        }
        public long template_item_cd { get; set; }
        public long template_group_cd { get; set; }
        public long template_item_type_cd { get; set; }
        public string template_item_etxt { get; set; }
        public string template_item_ftxt { get; set; }
        public long template_target_type_cd { get; set; }
        public long stored_value_ind { get; set; }
        public long mandatory_ind { get; set; }
        public long max_length_ind { get; set; }
        public Nullable<decimal> max_length_nbr { get; set; }
        public string format_mask_txt { get; set; }
        public Nullable<long> filter_template_item_cd { get; set; }
        public Nullable<long> filter_standard_response_ind { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual ICollection<cc302_inspection_profile> cc302_inspection_profile { get; set; }
        public virtual ty204_template_group ty204_template_group { get; set; }
        public virtual ty205_template_item_type ty205_template_item_type { get; set; }
        public virtual ty209_template_target_type ty209_template_target_type { get; set; }
    }
    public class ty206_template_itemConfiguration : EntityTypeConfiguration<ty206_template_item>
    {
        public ty206_template_itemConfiguration()
        {
            this.ToTable("SIRS.ty206_template_item");
            this.HasKey(s => s.template_item_cd);
            this.HasMany(m => m.cc302_inspection_profile).WithRequired(s => s.ty206_template_item);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.template_group_cd);
            this.Property(e => e.template_item_type_cd);
            this.Property(e => e.template_item_etxt);
            this.Property(e => e.template_item_ftxt);
            this.Property(e => e.template_target_type_cd);
            this.Property(e => e.stored_value_ind);
            this.Property(e => e.mandatory_ind);
            this.Property(e => e.max_length_ind);
            this.Property(e => e.max_length_nbr);
            this.Property(e => e.format_mask_txt);
            this.Property(e => e.filter_template_item_cd);
            this.Property(e => e.filter_standard_response_ind);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
