namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Animal;

    public interface IAnimalService
    {
        Task AddAnimal(AddAnimalViewModel addAnimal);

        Task DeleteAnimal(DeleteAnimalViewModel model);

        Task EditAnimal(EditAnimalViewModel model, int id);

        AllAnimalViewModel GetById<T>(int id);

        IEnumerable<AllAnimalViewModel> AllAnimals<T>();
    }
}
