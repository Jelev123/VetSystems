namespace VetSystem.Core.ViewModels.Animal
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using VetSystem.Core.ViewModels.Breed;

    public class AddAnimalViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public int BreedId { get; set; }

        public string BreedName { get; set; }

        public int DiseaseId { get; set; }

        public string DiseaseName { get; set; }

        public int OwnerId { get; set; }

        public string OwnerFirstName { get; set; }

        public string OwnerLastName { get; set; }

        public int PhoneNumber { get; set; }

        public string MedicationName { get; set; }
    }
}
