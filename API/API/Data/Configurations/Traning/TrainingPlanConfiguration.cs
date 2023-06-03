using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Traning;

namespace API.Data.Configurations.Traning
{
    public class TrainingPlanConfiguration : IEntityTypeConfiguration<TrainingPlan>
    {
        public void Configure(EntityTypeBuilder<TrainingPlan> builder)
        {
            builder.ToTable("TrainingPlan");
            builder.HasKey(e => e.IdTrainingPlan);

            builder.HasOne(e => e.Users)
                .WithMany(e => e.TrainingPlans)
                .HasForeignKey(e => e.IdUser);

            builder.HasOne(e => e.AdminAndModerator)
                .WithMany(e => e.TrainingPlansAdmins)
                .HasForeignKey(e => e.IdAdminAndModerator);


            //builder.Entity<TrainingPlan>()
            //    .HasOne(e => e.AdminAndModerator)
            //    .WithMany(e => e.TrainingPlansAdmins)
            //    .IsRequired();

            //builder.Entity<TrainingPlan>()
            //    .HasOne(e => e.Users)
            //    .WithMany(e => e.TrainingPlans)
            //    .IsRequired();

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
