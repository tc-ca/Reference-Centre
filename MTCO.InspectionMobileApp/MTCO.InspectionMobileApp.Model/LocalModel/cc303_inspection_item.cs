namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc303_inspection_item
    {
        public decimal inspection_id { get; set; }
        public long inspection_item_id { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
        public decimal user_last_update_id { get; set; }
        public System.DateTime date_def_created_dte { get; set; }
    
        public virtual cc301_inspection cc301_inspection { get; set; }
    }
    public class cc303_inspection_itemConfiguration : EntityTypeConfiguration<cc303_inspection_item>
    {
        public cc303_inspection_itemConfiguration()
        {
            this.ToTable("SIRS.cc303_inspection_item");
            this.HasKey(s => new { s.inspection_id, s.inspection_item_id });
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_item_id);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_def_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
            this.Property(e => e.user_last_update_id);
        }
    }


}
