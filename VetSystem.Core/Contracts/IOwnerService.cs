namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Owner;

    public interface IOwnerService
    {
        Task AddOwner(AddOwnerViewModel add);
        IEnumerable<AllOwnersViewModel> GetAll<T>();
    }
}
