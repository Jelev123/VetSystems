namespace VetSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Models;

    public class SearchController : Controller
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {

            this.searchService = searchService;
        }


        public IActionResult Search(string searchName)
        {
            if (string.IsNullOrWhiteSpace(searchName))
            {
                return this.View(searchName);
            }
            this.ViewData["searchAnimal"] = searchName;
            var searched = this.searchService.Search(searchName);
            return this.View(searched);
        }
    }
}
