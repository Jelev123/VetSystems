namespace VetSystem.Core
{
    using AutoMapper;
    using VetSystem.Core.ViewModels.Breed;
    using VetSystem.Infrastucture.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Breed, AllBreedsViewModel>();
        }
    }
}
