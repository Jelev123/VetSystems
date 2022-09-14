namespace VetSystem.Core.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public class AddAnimalViewModel
    {
        public List<string> list;


        public AddAnimalViewModel(List<string> list)
        {

            this.BreedName = list;
            this.DiseaseName = list;

        }


        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public int OwnerId { get; set; }

        [DisplayName("Breeds")]
        public int BreedId { get; set; }

        public List<string> BreedName { get; set; }

        public List<string> DiseaseName { get; set; }

        public int DiseaseId { get; set; }

    }
}
