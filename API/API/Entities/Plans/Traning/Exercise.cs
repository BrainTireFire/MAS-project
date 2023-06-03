namespace API.Entities.Plans.Traning
{
    public abstract class Exercise
    {
        public int IdExercise { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
       // public ICollection<string> Photos { get; set; }
       // public ICollection<string> Videos { get; set; }
        public string MuscleGroups { get; set; } = null!;
        public ICollection<ExerciseTraningPlan> ExerciseTraningPlans { get; set; } = new List<ExerciseTraningPlan>();
    }
}
