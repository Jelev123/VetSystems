namespace VetSystem.Infrastucture.Data.Models
{
    public class MedicationCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Medication> Medications { get; set; } = new HashSet<Medication>();


    }
}
