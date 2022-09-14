namespace VetSystem.Controllers.Animal
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.AccessControl;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.Models;
    using VetSystem.Infrastructure.Data;

    public class AnimalController : Controller
    {
        private readonly IAnimalService animalService;
        private readonly ApplicationDbContext data;

        public AnimalController(IAnimalService animalService, ApplicationDbContext data)
        {
            this.animalService = animalService;
            this.data = data;
        }


        public IActionResult Add()
        {
            var all = new Dictionary<int, string>();

            var breeds = this.data.Breeds;

            foreach (var item in breeds)
            {
                if (!all.ContainsKey(item.Id))
                {
                    all.Add(item.Id, item.Name);
                }
            }


            var animal = new AddAnimalViewModel(all.Values.ToList());
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
