using Microsoft.EntityFrameworkCore;
using vdivsvirus.Types;

namespace vdivsvirus.Models
{
    public class DataSetContext : DbContext
    {
        public DataSetContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SymptomeType> SymptomTypes { get; set; }
        public DbSet<DiseaseType> DiseaseTypes { get; set; }

        internal DbSet<UserDataHistory> UserDataHistories { get; set; }
    }
}