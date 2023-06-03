using API.Entities.Plans.Traning;

namespace API.Entities
{
    public class Motivator
    {
        public int IdMotivator { get; set; }
        public string Name { get; set; }
        public string Pseudonym { get; set; }
        //public ICollection<string> MotivatingWords { get; set; } = new List<string>();
        public ICollection<AppUser>  Users { get; set; } = new List<AppUser>();
    }
}
