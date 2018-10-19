using MTCO.InspectionMobileApp.Local.DTO;
using System.Data.Entity;

namespace MTCO.InspectionMobileApp.Local.DataAccess
{

    public partial class LocalContext : DbContext
    {
        public LocalContext()
            : base("name=LocalContext")
        {
            Database.SetInitializer<LocalContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new cc310_reference_centre_fileConfiguration());
        }

        public virtual DbSet<cc310_reference_centre_file> cc310_reference_centre_file { get; set; }
    }
}
