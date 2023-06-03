using API.Data;
using API.Entities.Plans.Diet;
using API.Interfaces;

namespace API.Services
{
    public class DbService : IDbService
    {
        private readonly DataContext _context;
        public DbService(DataContext context)
        {
            _context = context;
        }

        public async Task AddDishDietPlan(IEnumerable<DishDietPlan> dishDietPlan)
        {
            await _context.AddRangeAsync(dishDietPlan);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewDish(Dish dish)
        {
            await _context.AddAsync(dish);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewPlan(DietPlan dietPlan)
        {
            await _context.AddAsync(dietPlan);
            await _context.SaveChangesAsync();
        }
    }
}
