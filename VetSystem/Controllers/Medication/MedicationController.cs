namespace VetSystem.Controllers.Medication
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Medicament;
    using VetSystem.Core.ViewModels.MedicationCategory;

    public class MedicationController : Controller
    {
        private readonly IMedicationService medicationService;
        private readonly IMedicationCategoryService medicationCategoryService;

        public MedicationController(IMedicationService medicationService, IMedicationCategoryService medicationCategoryService)
        {
            this.medicationService = medicationService;
            this.medicationCategoryService = medicationCategoryService;
        }


        public IActionResult CreateMedication()
        {
            var allMedCategories = this.medicationCategoryService.AllMedCategories<AddMedicationCategoryViewModel>();

            this.ViewData["medCategories"] = allMedCategories.Select(s => new AddMedicatonViewModel
            {
                MedicationCategoryName = s.Name
            }).ToList();

            return this.View();
        }

        [HttpPost]
        public IActionResult CreateMedication(AddMedicatonViewModel add)
        {
            this.medicationService.AddMedicament(add);
            return this.Redirect("/");
        }
    }
}
