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


        public IActionResult CreateDisease()
        {
            var allDiseaseCategory = this.categoryService.AllDiseaseCategories<AllDiseaseCategories>();

            this.ViewData["diseaseCategory"] = allDiseaseCategory.Select(s => new AddDisieseViewModel
            {
                DiseaceCategoryName = s.Name,
            }).ToList();

            return this.View();
        }

        [HttpPost]
        public IActionResult CreateDisease(AddDisieseViewModel model)
        {
            var add =this.disieseService.CreateDisease(model);
            return this.Redirect("/");
        }
    }
}
