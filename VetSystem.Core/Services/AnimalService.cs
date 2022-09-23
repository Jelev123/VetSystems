namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
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

        public IEnumerable<AllAnimalViewModel> AllAnimals<T>()
        {
            var allAnimals = this.data.Animals
                .Select(s => new AllAnimalViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    Kilograms = s.Kilograms,
                    BreedName = s.Breed.Name,
                    DiseaseName = s.Diseases.Name,
                    MedicationName = s.Medication.Name,
                    OwnerFirstName = s.Owner.FirstName,
                    OwnerLastName = s.Owner.LastName,
                });

            return allAnimals;
        }

        public Task DeleteAnimal(DeleteAnimalViewModel model)
        {
            var animal = this.data.Animals.FirstOrDefault(s => s.Id == model.Id);
            this.data.Remove(animal);
            this.data.SaveChanges();
            return Task.CompletedTask;
        }

        public Task EditAnimal(EditAnimalViewModel model, int id)
        {
            var animal = this.data.Animals.FirstOrDefault(s => s.Id == id);
            animal.Name = model.Name;
            animal.Age = model.Age;
            animal.Kilograms = model.Kilograms;
            animal.DiseaseId = model.DiseaseId ;
            animal.MedicationId = model.MedicationId;
            animal.OwnerId = model.OwnerId;

            this.data.Update(animal);
            this.data.SaveChanges();
            return Task.CompletedTask;

        }

        public AllAnimalViewModel GetById<T>(int id)
        {
            var animal = this.data.Animals
                .Where(s => s.Id == id)
                .Select(s => new AllAnimalViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    Kilograms = s.Kilograms,
                    BreedName = s.Breed.Name,
                    DiseaseName = s.Diseases.Name,
                    MedicationName = s.Medication.Name,
                    OwnerFirstName = s.Owner.FirstName,
                    OwnerLastName = s.Owner.LastName,
                }).FirstOrDefault();

            return animal;

        }
    }
}
