using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Traning;
using System.Reflection.Emit;

namespace API.Data.Configurations.Traning
{
    public class ExerciseWithTheDeviceConfiguration : IEntityTypeConfiguration<ExerciseWithTheDevice>
    {
        public void Configure(EntityTypeBuilder<ExerciseWithTheDevice> builder)
        {
            builder.ToTable("ExerciseWithTheDevice");

            //builder.HasKey(e => e.IdExerciseDevice);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasMany(e => e.Instruments)
                   .WithMany(e => e.ExerciseWithTheDevices);

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
