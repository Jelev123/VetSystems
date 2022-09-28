namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class DiseaseCategoryService : IDiseaseCategoryService
    {
        private readonly ApplicationDbContext data;

        public DiseaseCategoryService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task CreateDiseaseCategory(AddDiseaseCategoryViewModel add)
        {
            var diseaseCategory = new DiseaseCategory
            {
                Name = add.Name,
            };

            data.Add(diseaseCategory);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AllDiseaseCategories> AllDiseaseCategories<T>()
        {
            return this.data.DiseaseCategories
                 .Select(s => new AllDiseaseCategories
                 {
                     Name = s.Name
                 });
        }
    }
}
