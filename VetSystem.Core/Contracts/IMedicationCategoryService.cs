namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.MedicationCategory;

    public interface IMedicationCategoryService
    {
        Task CreateMedicationCategory(AddMedicationCategoryViewModel addMedicationCategory);

        IEnumerable<AddMedicationCategoryViewModel> AllMedicationCategories<T>();
    }
}
