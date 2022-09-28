namespace VetSystem.Core.ViewModels.Animal
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class AddAnimalViewModel
    {     
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }
   
        public string? BreedName { get; set; }

        public string? DiseaseName { get; set; }

        public string? OwnerFirstName { get; set; }

        public string? OwnerLastName { get; set; }

        public string? MedicationName { get; set; }
    }
}
