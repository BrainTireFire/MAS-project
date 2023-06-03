namespace API.Entities.Plans.Traning
{
    public class ExerciseWithTheDevice : Exercise
    {
        public int IdExerciseDevice { get; set; }
        public ICollection<Instrument> Instruments { get; set; } = new List<Instrument>();
    }
}
