namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.MedicationCategory;

    public interface IMedicationCategoryService
    {
        Task AddMedicationCategory(AddMedicationCategoryViewModel addMedicationCategory);

        IEnumerable<AddMedicationCategoryViewModel> AllMedCategories<T>();
    }
}
