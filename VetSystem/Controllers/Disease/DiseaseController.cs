namespace VetSystem.Controllers.Disease
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Infrastructure.Data;

    public class DiseaseController : Controller
    {
        private readonly IDisieseService disieseService;
        private readonly ApplicationDbContext data;

        public DiseaseController(IDisieseService disieseService, ApplicationDbContext data)
        {
            this.disieseService = disieseService;
            this.data = data;
        }


        public IActionResult Add()
        {                    
            var view = new AddDisieseViewModel()
            {
                Name = data.Diseases.Select(d => d.Name).First(),
                DiseaseCategoryName = data.DiseaseCategories.Select(s => s.Name).First(),
                DiseaseCategoryId = data.DiseaseCategories.Select(s => s.Id).First(),
            };
            return this.View(view);
        }

        [HttpPost]
        public IActionResult Add(AddDisieseViewModel model)
        {
            var add =this.disieseService.AddDisiese(model);
            return this.Redirect("/");
        }
    }
}
