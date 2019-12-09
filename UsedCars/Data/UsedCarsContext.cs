using Microsoft.EntityFrameworkCore;
using UsedCars.Data.Configurations;
using UsedCars.Model;

namespace UsedCars.Data
{
    public class UsedCarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        //Color ifv new table color in DB
        public DbSet<Color> Colors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. hier Data source meegeven in deze op de ROOT: UsedCars.db
            optionsBuilder.UseSqlite(@"Data source=UsedCars.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 2. refer voor modelBuilder van Context naar Configurations
            modelBuilder.ApplyConfiguration(new UsedCarConfigurations()).Seed();
            /* cmd dotnet ef migrations add CreateDatabase --output-dir Data/Migrations ZONDER .Seed() !!!!*/
            /*vervolgens dotnet ef database update  */

            // 3. refer voor modelBuilder van Context naar Configurations maar nu voor ColorSeed
            modelBuilder.ApplyConfiguration(new ColorConfigurations()).SeedColor();
        }
    }
}