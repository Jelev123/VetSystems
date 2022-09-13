namespace VetSystem.Controllers.Animal
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.AccessControl;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.Models;

    public class AnimalController : Controller
    {
        private readonly IAnimalService animalService;

        public AnimalController(IAnimalService animalService)
        {
            this.animalService = animalService;
        }


        public IActionResult Add()
        {
            var animal = new AddAnimalViewModel();
            return this.View(animal);

        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAnimalViewModel addAnimal)
        {
            var add = this.animalService.AddAnimal(addAnimal);
            return this.Redirect("/");
        }

    }
}
