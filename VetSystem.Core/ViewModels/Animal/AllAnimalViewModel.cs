namespace VetSystem.Core.ViewModels.Animal
{
    using System.ComponentModel.DataAnnotations;

    public class AllAnimalViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        [Display(Name = "Breed")]
        public string? BreedName { get; set; }

        [Display(Name = "Disease")]

        public string? DiseaseName { get; set; }

        public int DiseaseId { get; set; }

        [Display(Name = "Owner Name")]

        public string? OwnerFirstName { get; set; }

        public string? OwnerLastName { get; set; }

        public string? MedicationName { get; set; }

        public bool IsHealed { get; set; }
    }
}
