namespace VetSystem.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class BreedService : IBreedService
    {
        private readonly ApplicationDbContext data;


        public BreedService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public async Task CreateBreed(AddBreedViewModel addBreed)
        {
            var breed = new Breed
            {
                Name = addBreed.Name,
            };

            data.Add(breed);
            data.SaveChanges();
            
        }

        public IEnumerable<AllBreedsViewModel> AllBreeds<T>()
        {
            var all = this.data.Breeds
                .Select(s => new AllBreedsViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                });

            return all;
        }
    }
}
