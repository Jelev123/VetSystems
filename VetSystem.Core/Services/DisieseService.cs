namespace VetSystem.Core.Services
{
    using Microsoft.EntityFrameworkCore;
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

        public async Task AddDisiese(AddDisieseViewModel add)
        {
            var name = data.DiseaseCategories.Select(s => s.Name);
            var disease = new Disease
            {
                Name = add.Name,
                DiseaseCategoryId = add.DiseaseCategoryId,
                DiseaseCategories = (DiseaseCategory)add.AllDiseaseCategories
            };
                         
            data.Add(disease);
            data.SaveChanges();
        }
    }
}
