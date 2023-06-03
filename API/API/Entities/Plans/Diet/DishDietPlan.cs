using API.Entities.Plans.Traning;

namespace API.Entities.Plans.Diet
{
    public class DishDietPlan
    {
        public int IdDishDietPlan { get; set; }
        public int IdDietPlan { get; set; }
        public int IdDish { get; set; }
        public ICollection<Dish> Dishes { get; set; } = null!;
        public DietPlan DietPlan { get; set; } = null!;
    }
}
