namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Disiese;

    public interface IDisieseService
    {
        Task CreateDisease(AddDisieseViewModel add);

        IEnumerable<AllDiseaseViewModel> AllDiseases<T>();
    }
}
