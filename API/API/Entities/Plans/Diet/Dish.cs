namespace API.Entities.Plans.Diet
{
    public class Dish
    {
        public int IdDish { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AmountOfCaloriesInTheDish { get; set; }
        public ICollection<DishDietPlan> DishDietPlans { get; set; } = new List<DishDietPlan>();
        public CompositionOfNutritionalValue CompositionOfNutritionalValue { get; set; } = null!;
    }
}
