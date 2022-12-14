namespace VetSystem.Infrastucture.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using VetSystem.Infrastructure.Data.Models;

    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public bool IsHealed { get; set; }

        public int? OwnerId { get; set; }

        public Owner? Owner { get; set; }

        public int? BreedId { get; set; }

        public Breed? Breed { get; set; }

        public int? DiseaseId { get; set; }

        public Disease? Diseases { get; set; }

        public int? MedicationId { get; set; }

        public Medication? Medication { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
