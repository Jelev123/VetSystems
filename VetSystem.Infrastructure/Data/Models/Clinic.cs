namespace VetSystem.Infrastucture.Data.Models
{
    public class Clinic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();

        public ICollection<Owner> Owners { get; set; } = new HashSet<Owner>();

        public ICollection<Medication> Medications { get; set; } = new HashSet<Medication>();

        public ICollection<MedicationCategory> MedicationCategories { get; set; } = new HashSet<MedicationCategory>();
    }
}
