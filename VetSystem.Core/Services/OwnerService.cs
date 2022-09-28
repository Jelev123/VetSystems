namespace VetSystem.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Owner;
    using VetSystem.Infrastructure.Data;
    using VetSystem.Infrastucture.Data.Models;

    public class OwnerService : IOwnerService
    {
        private readonly ApplicationDbContext data;

        public OwnerService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public Task CreateOwner(AddOwnerViewModel add)
        {
            var owner = new Owner
            {
                FirstName = add.FirstName,
                LastName = add.LastName,
                PhoneNumber = add.PhoneNumber,
            };

            data.Add(owner);
            data.SaveChanges();
            return Task.CompletedTask;
        }

        public IEnumerable<AllOwnersViewModel> AllOwners<T>()
        {
            return this.data.Owners
                .Select(s => new AllOwnersViewModel
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PhoneNumber = s.PhoneNumber,
                });
        }
    }
}
