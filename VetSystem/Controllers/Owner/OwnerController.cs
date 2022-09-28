namespace VetSystem.Controllers.Owner
{
    using Microsoft.AspNetCore.Mvc;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Owner;

    public class OwnerController : Controller
    {
        private readonly IOwnerService ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            this.ownerService = ownerService;
        }

        public IActionResult CreateOwner()
        {
            return View(new AddOwnerViewModel());
        }

        [HttpPost]
        public IActionResult CreateOwner(AddOwnerViewModel add)
        {
            var owner = this.ownerService.AddOwner(add);
            return Redirect("/");
        }
    }
}
