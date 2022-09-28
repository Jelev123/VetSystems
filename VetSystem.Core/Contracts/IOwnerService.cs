namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Owner;

    public interface IOwnerService
    {
        Task CreateOwner(AddOwnerViewModel add);
        IEnumerable<AllOwnersViewModel> AllOwners<T>();
    }
}
