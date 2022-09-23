namespace VetSystem.Core.ViewModels.Animal
{
    public class EditAnimalViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public string? BreedName { get; set; }

        public int BreedId { get; set; }

        public string? DiseaseName { get; set; }

        public int DiseaseId { get; set; }

        public string? OwnerFirstName { get; set; }

        public string? OwnerLastName { get; set; }

        public int OwnerId { get; set; }

        public string? MedicationName { get; set; }

        public int MedicationId { get; set; }
    }
}
