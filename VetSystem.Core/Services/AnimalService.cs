namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.Models;
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
            var animal = new Animal
            {
                Name = addAnimal.Name,
                Age = addAnimal.Age,
                Kilograms = addAnimal.Kilograms,
                BreedId = addAnimal.BreedId,
                //DiseaseId = addAnimal.DiseaseId,
                //OwnerId = addAnimal.OwnerId,

            };

            data.Add(animal);
            data.SaveChanges();
        }
    }
}
