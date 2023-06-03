using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data.Configurations
{
    public class MotivatorConfiguration : IEntityTypeConfiguration<Motivator>
    {
        public void Configure(EntityTypeBuilder<Motivator> builder)
        {
            builder.ToTable("Motivator");

            builder.HasKey(e => e.IdMotivator);

            builder.Property(e => e.Name).HasMaxLength(100);

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
