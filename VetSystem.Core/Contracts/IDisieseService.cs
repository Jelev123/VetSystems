namespace VetSystem.Core.Contracts
{
    using VetSystem.Core.ViewModels.Disiese;

    public interface IDisieseService
    {
        Task AddDisiese(AddDisieseViewModel add);
    }
}
