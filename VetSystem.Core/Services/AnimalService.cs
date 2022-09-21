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

        public async Task AddAnimal(AddAnimalViewModel addAnimal)
        {
            var breed = this.data.Breeds.FirstOrDefault(s => s.Name == addAnimal.BreedName);
            var animal = new Animal
            {
                Name = addAnimal.Name,
                Age = addAnimal.Age,
                Kilograms = addAnimal.Kilograms,
                Breed = breed,
            };

            data.Add(animal);
            data.SaveChanges();
        }
    }
}
