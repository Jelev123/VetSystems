namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Category;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastructure.Data.Models;

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext data;

        public CategoryService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task CreateCategory(CreateCategoryViewModel model)
        {
            var category = new Category
            {
                Name = model.Name,
            };

            data.Add(category);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AllCategoryViewModel> GetAllCategories<T>()
        {
            var allCategories = this.data.Categories
                 .Select(s => new AllCategoryViewModel
                 {
                     Name = s.Name
                 });

            return allCategories;
        }
    }
}
