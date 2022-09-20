namespace VetSystem.Infrastucture.Data.Models
{
    public class DiseaseCategory
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Disease> Diseases { get; set; } = new HashSet<Disease>();
    }
}
