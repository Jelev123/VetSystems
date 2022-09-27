namespace VetSystem.Core.Services
{
    using System.Threading.Tasks;
    using VetSystem.Core.Contracts;
    using VetSystem.Core.ViewModels.Animal;
    using VetSystem.Infrastructure.Data;

    public class SearchService : ISearchService
    {
        private readonly ApplicationDbContext data;

        public SearchService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<AllAnimalViewModel> Search(string searchName)
        {
            var animal = this.data.Animals
                .Select(s => new AllAnimalViewModel
                {
                    Name = s.Name,
                    Age = s.Age,
                    Kilograms = s.Kilograms,
                    BreedName = s.Breed.Name,
                    DiseaseName = s.Diseases.Name,
                    MedicationName = s.Medication.Name,
                    OwnerFirstName = s.Owner.FirstName,
                    OwnerLastName = s.Owner.LastName,
                    IsHealed = s.IsHealed
                })
                .Where(s => s.Name.Contains(searchName)).ToList();

            return animal;
        }
    }
}
