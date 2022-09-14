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

        public IActionResult Add()
        {
            var view = new AddDiseaseCategoryViewModel();
            return this.View(view);
        }

        [HttpPost]
        public IActionResult Add(AddDiseaseCategoryViewModel add)
        {
            var diseaseCategory = this.diseaseCategoryService.Add(add);
            return this.Redirect("/");
            
        }
    }
}
