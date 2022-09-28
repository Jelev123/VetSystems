namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Medicament;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class MedicationService : IMedicationService
    {

        private readonly ApplicationDbContext data;

        public MedicationService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task CreateMedication(AddMedicatonViewModel addMedications)
        {
            var medCategories = this.data.MedicationCategories.FirstOrDefault(s => s.Name == addMedications.MedicationCategoryName);
            var medication = new Medication
            {
                Name = addMedications.Name,
                MedicationsCategory = medCategories,
                MedicationsCategoryId = medCategories.Id,
            };

            data.Add(medication);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AddMedicatonViewModel> AllMedication<T>()
        {
            return this.data.Medications
                .Select(s => new AddMedicatonViewModel
                {
                    Name = s.Name,
                });
        }
    }
}
