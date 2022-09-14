namespace VetSystem.Core.Services
{
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

        public async Task Add(AddDiseaseCategoryViewModel add)
        {
            var disease = new DiseaseCategory
            {
                Name = add.Name,
            };

            data.Add(disease);
            data.SaveChanges();
        }
    }
}
