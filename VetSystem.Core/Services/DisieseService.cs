namespace VetSystem.Core.Services
{
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

        public Task AddDisiese(AddDisieseViewModel add)
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
    }
}
