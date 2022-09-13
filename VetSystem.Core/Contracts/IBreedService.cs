namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels;

    public interface IBreedService
    {
        Task AddBreed(AddBreedViewModel addBreed);
    }
}
