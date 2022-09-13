namespace VetSystem.Infrastucture.Data.Models
{
    public class Medication
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MedicationsCategoryId { get; set; }

        public MedicationCategory MedicationsCategory { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();

    }
}
