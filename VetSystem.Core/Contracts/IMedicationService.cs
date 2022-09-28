namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Medicament;

    public interface IMedicationService
    {
        Task CreateMedication(AddMedicatonViewModel addMedications);

        IEnumerable<AddMedicatonViewModel> AllMedication<T>();
    }
}
