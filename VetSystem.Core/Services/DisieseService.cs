namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class DisieseService : IDisieseService
    {
        private readonly ApplicationDbContext data;

        public DisieseService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task CreateDisease(AddDisieseViewModel add)
        {
            var diseaseCategory = data.DiseaseCategories.FirstOrDefault(s => s.Name == add.DiseaceCategoryName);

            var disease = new Disease
            {
                Name = add.Name,
                DiseaseCategories = diseaseCategory,
                DiseaseCategoryId = diseaseCategory.Id,
            };

            data.Add(disease);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AllDiseaseViewModel> AllDiseases<T>()
        {
            return this.data.Diseases
                .Select(s => new AllDiseaseViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                });
        }
    }
}
