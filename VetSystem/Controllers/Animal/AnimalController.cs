namespace VetSystem.Controllers.Animal
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.AccessControl;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Infrastructure.Data;

    public class AnimalController : Controller
    {
        private readonly IAnimalService animalService;
        private readonly IBreedService breedService;

        public AnimalController(IAnimalService animalService, IBreedService breedService)
        {
            this.animalService = animalService;
            this.breedService = breedService;
        }


        public IActionResult Add()
        {
            var allBreeds = this.breedService.AllBreeds<AllBreedsViewModel>();

            this.ViewData["breeds"] = allBreeds.Select(s => new AddAnimalViewModel
            {
                BreedName = s.Name,
            }).ToList();
       
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAnimalViewModel addAnimal)
        {
            var add = this.animalService.AddAnimal(addAnimal);
            return this.Redirect("/");
        }

    }
}
