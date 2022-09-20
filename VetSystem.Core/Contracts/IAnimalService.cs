namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Animal;

    public interface IAnimalService
    {
        Task AddAnimal(AddAnimalViewModel addAnimal);
    }
}
