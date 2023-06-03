using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Diet;
using API.Entities.Plans.Traning;

namespace API.Data.Configurations.Diet
{
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.ToTable("Dish");

            builder.HasKey(e => e.IdDish);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasOne(e => e.CompositionOfNutritionalValue)
                   .WithOne(e => e.Dish)
                   .HasForeignKey<CompositionOfNutritionalValue>(e => e.IdCompositionOfNutritionalValue);

            //builder.HasData(new List<Dish>
            //{
            //    new Dish {
            //        ID = 1,
            //        FirstName = "Jan",
            //        LastName = "Kowalski"
            //    },
            //    new Dish {
            //        ID = 2,
            //        FirstName = "Anna",
            //        LastName = "Nowak"
            //    }
            //});
        }
    }
}
