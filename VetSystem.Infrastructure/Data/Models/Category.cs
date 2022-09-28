namespace VetSystem.Infrastructure.Data.Models
{
    using VetSystem.Infrastucture.Data.Models;

    public class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
