using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Entities.Plans.Diet;

namespace API.Data.Configurations.Diet
{
    public class DishDietPlanConfiguration : IEntityTypeConfiguration<DishDietPlan>
    {
        public void Configure(EntityTypeBuilder<DishDietPlan> builder)
        {
            builder.ToTable("DishDietPlan");
            builder.HasKey(e => e.IdDishDietPlan);

            builder.HasOne(e => e.DietPlan)
                .WithMany(e => e.DishDietPlans)
                .HasForeignKey(e => e.IdDietPlan);

            builder.HasMany(e => e.Dishes)
                   .WithMany(e => e.DishDietPlans);
                   //.UsingEntity(j => j.ToTable("DishDietPlans")); ;

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
