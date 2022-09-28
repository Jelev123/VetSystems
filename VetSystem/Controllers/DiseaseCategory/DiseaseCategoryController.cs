namespace VetSystem.Controllers.DiseaseCategory
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Infrastructure.Data;

    public class DiseaseCategoryController : Controller
    {
        private readonly IDiseaseCategoryService diseaseCategoryService;

        public DiseaseCategoryController(IDiseaseCategoryService diseaseCategoryService)
        {
            this.diseaseCategoryService = diseaseCategoryService;
        }

        public IActionResult CreateDiseaseCategory()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiseaseCategory(AddDiseaseCategoryViewModel add)
        {
            await this.diseaseCategoryService.CreateDiseaseCategory(add);
            return this.Redirect("/");
            
        }
    }
}
