namespace VetSystem.Controllers.Animal
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Security.AccessControl;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Core.ViewModels.Category;
    using VetSystem.Core.ViewModels.Disiese;
    using VetSystem.Core.ViewModels.Medicament;
    using VetSystem.Core.ViewModels.Owner;
    using VetSystem.Infrastructure.Data;

    public class AnimalController : Controller
    {
        private readonly IAnimalService animalService;
        private readonly IBreedService breedService;
        private readonly IDisieseService disieseService;
        private readonly IOwnerService ownerService;
        private readonly IMedicationService medicationService;
        private readonly ICategoryService categoryService;
        private readonly ApplicationDbContext data;

        public AnimalController(IAnimalService animalService, IBreedService breedService,
            IDisieseService disieseService, IOwnerService ownerService,
            IMedicationService medicationService,
            ApplicationDbContext data, ICategoryService categoryService)
        {
            this.animalService = animalService;
            this.breedService = breedService;
            this.disieseService = disieseService;
            this.ownerService = ownerService;
            this.medicationService = medicationService;
            this.data = data;
            this.categoryService = categoryService;
        }


        public IActionResult Add()
        {
            var allBreeds = this.breedService.AllBreeds<AllBreedsViewModel>();
            var allDisease = this.disieseService.AllDiseases<AllDiseaseViewModel>();
            var allOwners = this.ownerService.AllOwners<AllOwnersViewModel>();
            var allMedication = this.medicationService.AllMedication<AddMedicatonViewModel>();
            var allCategories = this.categoryService.GetAllCategories<AllCategoryViewModel>();

            this.ViewData["breeds"] = allBreeds.Select(s => new AddAnimalViewModel
            {
                BreedName = s.Name,
            }).ToList();

            this.ViewData["diseases"] = allDisease.Select(s => new AddAnimalViewModel
            {
                DiseaseName = s.Name,
            }).ToList();

            this.ViewData["ownerFirstName"] = allOwners.Select(s => new AddAnimalViewModel
            {
               OwnerFirstName = s.FirstName,
            }).ToList();

            this.ViewData["ownerLastName"] = allOwners.Select(s => new AddAnimalViewModel
            {
                OwnerLastName = s.LastName,
            }).ToList();

            this.ViewData["medication"] = allMedication.Select(s => new AddAnimalViewModel
            {
               MedicationName = s.Name
            }).ToList();


            this.ViewData["categories"] = allCategories.Select(s => new AddAnimalViewModel
            {
                CategoryName = s.Name,
            }).ToList();

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAnimalViewModel addAnimal)
        {
            var add = this.animalService.AddAnimal(addAnimal);
            return this.Redirect("/");
        }

        public IActionResult DeleteAnimal(DeleteAnimalViewModel model)
        {
            this.animalService.DeleteAnimal(model);
            return this.RedirectToAction("AllAnimals");
        }

        public IActionResult AllAnimals()
        {
            var all = this.animalService.AllAnimals<AllAnimalViewModel>();
            return this.View(all);
        }

        public IActionResult GetById(int id)
        {
            var animal = this.animalService.GetById<AllAnimalViewModel>(id);
            return this.View(animal);
        }

        public IActionResult EditAnimal(int id)
        {
            var animal = this.animalService.GetById<AllAnimalViewModel>(id);
            return this.View(animal);
        }

        [HttpPost]
        public IActionResult EditAnimal(EditAnimalViewModel model, int id)
        {
            var animal = this.animalService.EditAnimal(model,id);
            return this.Redirect("/");
        }

        public IActionResult Heal(int id)
        {
            var heal = this.animalService.Heal(id);
            return this.Redirect("/");
        }
    }
}
