using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Traning;

namespace API.Data.Configurations.Traning
{
    public class ExerciseTraningPlanConfiguration : IEntityTypeConfiguration<ExerciseTraningPlan>
    {
        public void Configure(EntityTypeBuilder<ExerciseTraningPlan> builder)
        {
            builder.ToTable("ExerciseTraningPlan");
            builder.HasKey(e => e.IdExerciseTraningPlan);

            builder.HasOne(e => e.TrainingPlan)
                .WithMany(e => e.ExerciseTraningPlans)
                .HasForeignKey(e => e.IdTraningPlan);

            builder.HasMany(e => e.Exercises)
                   .WithMany(e => e.ExerciseTraningPlans);

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
