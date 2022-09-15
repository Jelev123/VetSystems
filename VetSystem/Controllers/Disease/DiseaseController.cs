namespace VetSystem.Controllers.Disease
{
    using Microsoft.AspNetCore.Mvc;
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
            var all = new Dictionary<int, string>();

            var diseaseCategory = this.data.DiseaseCategories;

            foreach (var item in diseaseCategory)
            {
                if (!all.ContainsKey(item.Id))
                {
                    all.Add(item.Id,item.Name);
                }
            }

            var view = new AddDisieseViewModel(all.Values.ToList());
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
