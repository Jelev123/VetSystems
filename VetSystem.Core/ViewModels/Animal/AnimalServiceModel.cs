namespace VetSystem.Core.ViewModels.Animal
{
    using VetSystem.Core.ViewModels.Breed;

    public class AnimalServiceModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public int BreedId { get; set; }

        public AnimalBreedsServiceModel Breeds { get; set; }
    }
}
