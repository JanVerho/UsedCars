using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsedCars.Model;

namespace UsedCars.Data.Configurations
{
    public class UsedCarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //empty data table, contains only columns with exact the same name and props
        }
    }
}