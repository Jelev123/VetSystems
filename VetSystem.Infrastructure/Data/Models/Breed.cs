namespace VetSystem.Infrastucture.Data.Models
{
    public class Breed
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
