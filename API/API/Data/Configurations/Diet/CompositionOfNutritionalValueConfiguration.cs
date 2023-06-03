using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Configurations.Diet
{
    public class CompositionOfNutritionalValueConfiguration : IEntityTypeConfiguration<CompositionOfNutritionalValue>
    {
        public void Configure(EntityTypeBuilder<CompositionOfNutritionalValue> builder)
        {
            builder.ToTable("CompositionOfNutritionalValue");

            builder.HasKey(e => e.IdCompositionOfNutritionalValue);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

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
