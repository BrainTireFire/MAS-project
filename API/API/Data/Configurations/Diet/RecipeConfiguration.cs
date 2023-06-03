using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Configurations.Diet
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Recipe");
            builder.HasKey(e => e.IdRecipe);

            builder.HasOne(e => e.User)
                .WithMany(e => e.Recipes);


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
