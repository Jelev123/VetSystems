namespace VetSystem.Controllers.Disease
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Infrastructure.Data;

    public class DiseaseController : Controller
    {
        private readonly IDisieseService disieseService;
        private readonly IDiseaseCategoryService categoryService;
        private readonly ApplicationDbContext data;

        public DiseaseController(IDisieseService disieseService, ApplicationDbContext data, IDiseaseCategoryService categoryService)
        {
            this.disieseService = disieseService;
            this.data = data;
            this.categoryService = categoryService;
        }


        public IActionResult Add()
        {
            var allDiseaseCategory = this.categoryService.AllDiseaseCategories<AllDiseaseCategories>();

            this.ViewData["diseaseCategory"] = allDiseaseCategory.Select(s => new DiseaseCategoryViewDataModel
            {
                Name = s.Name,
            }).ToList();

            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddDisieseViewModel model)
        {
            var add =this.disieseService.AddDisiese(model);
            return this.Redirect("/");
        }
    }
}
