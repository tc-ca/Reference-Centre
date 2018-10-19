namespace MTCO.InspectionMobileApp.Model.LocalModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public partial class cc306_insp_item_attachment
    {
        public long attachment_id { get; set; }
        public decimal inspection_id { get; set; }
        public decimal inspection_item_id { get; set; }
        public long template_item_cd { get; set; }
        public byte[] attachment_lob { get; set; }
        public decimal user_last_update_id { get; set; }
        public System.DateTime date_created_dte { get; set; }
        public Nullable<System.DateTime> date_deleted_dte { get; set; }
        public System.DateTime date_last_update_dte { get; set; }
    }
    public class cc306_insp_item_attachmentConfiguration : EntityTypeConfiguration<cc306_insp_item_attachment>
    {
        public cc306_insp_item_attachmentConfiguration()
        {
            this.ToTable("SIRS.cc306_insp_item_attachment");
            this.HasKey(s => s.attachment_id);
            this.Property(e => e.attachment_id);
            this.Property(e => e.inspection_id);
            this.Property(e => e.inspection_item_id);
            this.Property(e => e.template_item_cd);
            this.Property(e => e.attachment_lob);
            this.Property(e => e.user_last_update_id);
            this.Property(e => e.date_created_dte);
            this.Property(e => e.date_deleted_dte);
            this.Property(e => e.date_last_update_dte);
        }
    }


}
