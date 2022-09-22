namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.MedicationCategory;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class MedicationCategoryService : IMedicationCategoryService
    {
        private readonly ApplicationDbContext data;

        public MedicationCategoryService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task AddMedicationCategory(AddMedicationCategoryViewModel addMedicationCategory)
        {
            var medCategory = new MedicationCategory
            {
                Name = addMedicationCategory.Name,
            };

            data.Add(medCategory);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AddMedicationCategoryViewModel> AllMedCategories<T>()
        {
            var all = this.data.MedicationCategories
                .Select(s => new AddMedicationCategoryViewModel
                {
                    Name = s.Name,

                });

            return all;
        }
    }
}
