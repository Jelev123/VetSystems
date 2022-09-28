namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Breed;

    public interface IBreedService
    {
        Task CreateBreed(AddBreedViewModel addBreed);

        IEnumerable<AllBreedsViewModel> AllBreeds<T>();
    }
}
