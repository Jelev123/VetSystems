namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class AnimalService : IAnimalService
    {
        private readonly ApplicationDbContext data;

        public AnimalService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task AddAnimal(AddAnimalViewModel addAnimal)
        {
            var breed = data.Breeds.FirstOrDefault(s => s.Name == addAnimal.BreedName);
            var disease = data.Diseases.FirstOrDefault(s => s.Name == addAnimal.DiseaseName);
            var owner = data.Owners.FirstOrDefault(s => s.FirstName == addAnimal.OwnerFirstName);
            var medication = data.Medications.FirstOrDefault(s => s.Name == addAnimal.MedicationName);
            var animal = new Animal
            {
                Name = addAnimal.Name,
                Age = addAnimal.Age,
                Kilograms = addAnimal.Kilograms,
                Breed = breed,
                BreedId = breed.Id,
                Diseases = disease,
                DiseaseId = disease.Id,
                Owner = owner,
                OwnerId = owner.Id,
                Medication = medication,
                MedicationId = medication.Id,
            };

            data.Add(animal);
            data.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
