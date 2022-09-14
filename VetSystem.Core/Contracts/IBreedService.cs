namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels;
    using VetSystem.Core.ViewModels.Breed;

    public interface IBreedService
    {
        Task AddBreed(AddBreedViewModel addBreed);

        IEnumerable<AllBreedsViewModel> AllBreeds<T>();
    }
}
