namespace VetSystem.Infrastucture.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

        public int BreedId { get; set; }

        public Breed Breed { get; set; }

        public int DiseaseId { get; set; }

        public Disease Diseases { get; set; }
    }
}
