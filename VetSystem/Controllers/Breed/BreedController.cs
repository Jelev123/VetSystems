namespace VetSystem.Controllers.Breed
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Breed;

    public class BreedController : Controller
    {
        private readonly IBreedService breedService;

        public BreedController(IBreedService breedService)
        {
            this.breedService = breedService;
        }

        public IActionResult CreateBreed()
        {
            var view = new AddBreedViewModel();
            return this.View(view);
        }

        [HttpPost]
        public IActionResult CreateBreed(AddBreedViewModel addBreed)
        {
            this.breedService.AddBreed(addBreed);

            return this.Redirect("/");
        }

        public IActionResult AllBreeds()
        {
            var all = this.breedService.AllBreeds<AllBreedsViewModel>();
            return this.View(all);
        }
    }
}
