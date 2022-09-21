namespace VetSystem.Controllers.Disease
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Infrastructure.Data;

    public class DiseaseController : Controller
    {
        private readonly IDisieseService disieseService;
        private readonly IDiseaseCategoryService categoryService;

        public DiseaseController(IDisieseService disieseService,IDiseaseCategoryService categoryService)
        {
            this.disieseService = disieseService;
            this.categoryService = categoryService;
        }


        public IActionResult Add()
        {
            var allDiseaseCategory = this.categoryService.AllDiseaseCategories<AllDiseaseCategories>();

            this.ViewData["diseaseCategory"] = allDiseaseCategory.Select(s => new AddDisieseViewModel
            {
                DiseaceCategoryName = s.Name,
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
