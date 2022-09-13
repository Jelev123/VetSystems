namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.Models;

    public interface IAnimalService
    {
        Task AddAnimal(AddAnimalViewModel addAnimal);
    }
}
