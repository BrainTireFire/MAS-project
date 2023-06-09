﻿namespace API.Entities.Plans.Diet
{
    public class DietPlan
    {
        public int IdDietPlan { get; set; }
        public int? IdUser { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PlanCalories { get; set; }
        public bool Active { get; set; }
        public ICollection<DishDietPlan> DishDietPlans { get; set; } = new List<DishDietPlan>();
        public AppUser AdminsAndModerator { get; set; } = null!;
        public AppUser? User { get; set; } = null;
    }
}
