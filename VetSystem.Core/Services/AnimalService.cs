namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Infrastructure.Data;

    public class AnimalService : IAnimalService
    {
        private readonly ApplicationDbContext data;

        public AnimalService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public async Task AddAnimal(AddAnimalViewModel addAnimal)
        {
            AnimalServiceModel animal = new AnimalServiceModel
            {
                Name = addAnimal.Name,
                Kilograms = addAnimal.Kilograms,
                Age = addAnimal.Age,
                BreedId = addAnimal.BreedId,
                Breeds = new AnimalBreedsServiceModel
                {
                    Name = addAnimal.Breeds,
                }  
            };

            data.Add(animal);
            data.SaveChanges();
        }
    }
}
