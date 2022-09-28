namespace VetSystem.Core.ViewModels.Animal
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class AddAnimalViewModel
    {     
        public string Name { get; set; }

        [Display(Name ="Category")]
        public string CategoryName { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        [Display(Name = "Breed")]

        public string? BreedName { get; set; }

        [Display(Name = "Disease")]

        public string? DiseaseName { get; set; }

        [Display(Name = "Owner - First Name")]

        public string? OwnerFirstName { get; set; }

        [Display(Name = "Owner - Last Name")]

        public string? OwnerLastName { get; set; }

        [Display(Name = "Medication")]

        public string? MedicationName { get; set; }
    }
}
