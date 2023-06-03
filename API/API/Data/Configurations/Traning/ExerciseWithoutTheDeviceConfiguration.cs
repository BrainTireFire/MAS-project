using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Traning;

namespace API.Data.Configurations.Traning
{
    public class ExerciseWithoutTheDeviceConfiguration : IEntityTypeConfiguration<ExerciseWithoutTheDevice>
    {
        public void Configure(EntityTypeBuilder<ExerciseWithoutTheDevice> builder)
        {
            builder.ToTable("ExerciseWithoutTheDevice");

            //builder.HasKey(e => e.IdExerciseDevice);

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
