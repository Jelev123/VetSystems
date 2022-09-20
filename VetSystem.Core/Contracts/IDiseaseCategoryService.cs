namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Core.ViewModels.DiseaseCategory;

    public interface IDiseaseCategoryService
    {
        Task Add(AddDiseaseCategoryViewModel add);

        IEnumerable<AllDiseaseCategories> AllDiseaseCategories<T>();

    }
}
