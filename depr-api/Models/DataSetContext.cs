using Microsoft.EntityFrameworkCore;
using vdivsvirus.Types;

namespace vdivsvirus.Models
{
    public class DataSetContext : DbContext
    {
        public DataSetContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Helpers.GetRDSConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SymptomeType>()
                .HasData(
                    new SymptomeType { id = 1, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Fieber", settings = "min=36.5;max=42.5;step=0.1" }, symptomePropability = (float)87.9, ScaleFunc = input => input * 1000 },
                    new SymptomeType { id = 2, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Husten", settings = "min=0;max=100;step=1" }, symptomePropability = (float)67.7 },
                    new SymptomeType { id = 3, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Abgeschlagenheit", settings = "min=0;max=100;step=1" }, symptomePropability = (float)38.1 },
                    new SymptomeType { id = 4, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Kurzatmigkeit", settings = "min=0;max=100;step=1" }, symptomePropability = (float)18.6 },
                    new SymptomeType { id = 5, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Muskel-/Gelenkschmerz", settings = "min=0;max=100;step=1" }, symptomePropability = (float)14.8 },
                    new SymptomeType { id = 6, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Halsschmerz", settings = "min=0;max=100;step=1" }, symptomePropability = (float)13.9 },
                    new SymptomeType { id = 7, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Kopfschmerz", settings = "min=0;max=100;step=1" }, symptomePropability = (float)13.6 },
                    new SymptomeType { id = 8, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Schüttelfrost", settings = "min=0;max=100;step=1" }, symptomePropability = (float)11.4 },
                    new SymptomeType { id = 9, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Übelkeit", settings = "min=0;max=100;step=1" }, symptomePropability = (float)5.0 },
                    new SymptomeType { id = 10, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Verstopfte Nase", settings = "min=0;max=100;step=1" }, symptomePropability = (float)4.8 },
                    new SymptomeType { id = 11, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Durchfall", settings = "min=0;max=100;step=1" }, symptomePropability = (float)3.7 }
                );

            modelBuilder.Entity<DiseaseType>()
                .HasData(
                    new DiseaseType { id = 1,  name = "covid-19", desc = "Corona"}
                );
        }

        public DbSet<SymptomeType> SymptomTypes { get; set; }
        public DbSet<DiseaseType> DiseaseTypes { get; set; }

        internal DbSet<UserDataHistory> UserDataHistories { get; set; }
    }
}