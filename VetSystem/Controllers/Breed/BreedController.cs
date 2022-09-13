namespace VetSystem.Controllers.Breed
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels;

    public class BreedController : Controller
    {
        private readonly IBreedService breedService;

        public BreedController(IBreedService breedService)
        {
            this.breedService = breedService;
        }

        public IActionResult Add()
        {
            var view = new AddBreedViewModel();
            return this.View(view);
        }

        [HttpPost]
        public IActionResult Add(AddBreedViewModel addBreed)
        {
            this.breedService.AddBreed(addBreed);

            return this.Redirect("/");
        }
    }
}
