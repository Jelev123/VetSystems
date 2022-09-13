namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class BreedService : IBreedService
    {
        private readonly ApplicationDbContext data;

        public BreedService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public async Task AddBreed(AddBreedViewModel addBreed)
        {
            var breed = new Breed
            {
                Name = addBreed.Name,
            };

            data.Add(breed);
            data.SaveChanges();
            
        }
    }
}
