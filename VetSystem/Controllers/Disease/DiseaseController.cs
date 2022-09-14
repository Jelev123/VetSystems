namespace VetSystem.Controllers.Disease
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Disiese;

    public class DiseaseController : Controller
    {
        private readonly IDisieseService disieseService;

        public DiseaseController(IDisieseService disieseService)
        {
            this.disieseService = disieseService;
        }


        public IActionResult Add()
        {
            var view = new AddDisieseViewModel();
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
