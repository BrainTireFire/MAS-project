using API.Entities.Plans.Diet;

namespace API.Interfaces
{
    public interface IDbService
    {
        Task AddNewDish(Dish dish);
        Task AddNewPlan(DietPlan dietPlan);
        Task AddDishDietPlan(IEnumerable<DishDietPlan> dishDietPlan);
    }
}
