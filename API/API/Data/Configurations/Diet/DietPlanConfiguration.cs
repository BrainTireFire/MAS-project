using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Configurations.Diet
{
    public class DietPlanConfiguration : IEntityTypeConfiguration<DietPlan>
    {
        public void Configure(EntityTypeBuilder<DietPlan> builder)
        {
            builder.ToTable("DietPlan");
            builder.HasKey(e => e.IdDietPlan);

            builder.HasOne(e => e.User)
                .WithMany(e => e.DietPlans)
                .HasForeignKey(e => e.IdUser);

            builder.HasOne(e => e.AdminsAndModerator)
                .WithMany(e => e.DietPlansAdmins)
                .HasForeignKey(e => e.IdDietPlan);

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
