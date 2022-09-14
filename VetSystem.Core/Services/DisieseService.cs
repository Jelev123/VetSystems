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

        public async Task AddDisiese(AddDisieseViewModel add)
        {
            var disease = new Disease
            {
                Id = add.Id,
                Name = add.Name,
            };

            data.Add(disease);
            data.SaveChanges();
        }
    }
}
