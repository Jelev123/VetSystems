namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Category;

    public interface ICategoryService
    {
        Task CreateCategory(CreateCategoryViewModel model);

        IEnumerable<AllCategoryViewModel> GetAllCategories<T>();
    }
}
