namespace VetSystem.Infrastucture.Data.Models
{
    public class Disease
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DiseaseCategoryId { get; set; }

        public DiseaseCategory DiseaseCategories { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
