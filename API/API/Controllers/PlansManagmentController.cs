using API.DTOs;
using API.Entities.Plans.Diet;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansManagmentController : ControllerBase
    {
        private readonly IDbService _dbService;
        public PlansManagmentController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpPost]
        public async Task<IActionResult> AddNewDietPlanData(NewPlanDTO newPlanDTO)
        {
            var planData = new DietPlan
            {
                Name = newPlanDTO.Name,
                Description = newPlanDTO.Description,
                PlanCalories = newPlanDTO.PlanCalories,
                Active = newPlanDTO.Active,
            };

            var dish = new Dish
            {
                IdDish = 4,
                Name = "Jablko",
                Description = "Description",
                AmountOfCaloriesInTheDish = 1000
            };

            var dishDietPlan = new List<DishDietPlan>();
            dishDietPlan.Add(new DishDietPlan
            {
                IdDish = 3,
                IdDietPlan = planData.IdDietPlan,
                DietPlan = planData
            });
            dishDietPlan.Add(new DishDietPlan
            {
                IdDish = 4,
                IdDietPlan = planData.IdDietPlan,
                DietPlan = planData
            });
            //foreach (var newDish in newPlanDTO.DishDietPlans)
            //{

            //}

            //using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            //{
                await _dbService.AddNewDish(dish);
                await _dbService.AddNewPlan(planData);
                await _dbService.AddDishDietPlan(dishDietPlan);

            //    scope.Complete();
            //}

            return Created("api/PlansManagment", "");
        }
    }
}
