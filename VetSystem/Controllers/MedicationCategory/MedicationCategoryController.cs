namespace VetSystem.Controllers.MedicationCategory
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.MedicationCategory;

    public class MedicationCategoryController : Controller
    {
        private readonly IMedicationCategoryService medCategoryService;

        public MedicationCategoryController(IMedicationCategoryService medCategoryService)
        {
            this.medCategoryService = medCategoryService;
        }

        public IActionResult CreateMedicationCategory()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult CreateMedicationCategory(AddMedicationCategoryViewModel addMedCategory)
        {
            this.medCategoryService.AddMedicationCategory(addMedCategory);
            return this.Redirect("/");
        }

        public IActionResult AllMedCategories()
        {
            var all = this.medCategoryService.AllMedCategories<AddMedicationCategoryViewModel>();
            return this.View(all);
        }
    }
}
