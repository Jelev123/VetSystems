namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Infrastructure.Data;

    public class DisieseService : IDisieseService
    {
        private readonly ApplicationDbContext data;

        public DisieseService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task AddDisiese(AddDisieseViewModel add)
        {
            DiseseServiceModel disease = new DiseseServiceModel
            {
                Name = add.Name,
                DiseaseCategories = new DiseaseCategoryServiceModel
                {
                    Name = add.DiseaseCategories,
                }
            };

            data.Add(disease);
            data.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
