namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Animal;

    public interface ISearchService
    {
       IEnumerable<AllAnimalViewModel> Search(string searchName);
    }
}
