namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc301_inspection
    {
        public cc301_inspection()
        {
            this.cc302_inspection_profile = new HashSet<cc302_inspection_profile>();
            this.cc309_inspector_assignment = new HashSet<cc309_inspector_assignment>();
            this.cc303_inspection_item = new HashSet<cc303_inspection_item>();
        }
    
        public decimal inspection_id { get; set; }
        public long template_type_cd { get; set; }
        public Nullable<System.DateTime> date_checkout_dte { get; set; }
        public string location_txt { get; set; }
        public Nullable<decimal> latitude_gis { get; set; }
        public Nullable<decimal> longitude_gis { get; set; }
        public Nullable<decimal> elevation_gis { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
    
        public virtual ty202_template_type ty202_template_type { get; set; }
        public virtual ICollection<cc302_inspection_profile> cc302_inspection_profile { get; set; }
        public virtual ICollection<cc309_inspector_assignment> cc309_inspector_assignment { get; set; }
        public virtual ICollection<cc303_inspection_item> cc303_inspection_item { get; set; }
    }
    public class cc301_inspectionConfiguration : EntityTypeConfiguration<cc301_inspection>
    {
        public cc301_inspectionConfiguration()
        {
            this.ToTable("SIRS.cc301_inspection");
            this.HasKey(s => s.inspection_id);
            this.HasMany(m => m.cc302_inspection_profile).WithRequired(s => s.cc301_inspection);
            this.HasMany(m => m.cc303_inspection_item).WithRequired(s => s.cc301_inspection);
            this.HasMany(m => m.cc309_inspector_assignment).WithRequired(s => s.cc301_inspection);
            this.Property(e => e.inspection_id);
            this.Property(e => e.template_type_cd);
            this.Property(e => e.date_checkout_dte);
            this.Property(e => e.location_txt);
            this.Property(e => e.latitude_gis);
            this.Property(e => e.longitude_gis);
            this.Property(e => e.elevation_gis);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
