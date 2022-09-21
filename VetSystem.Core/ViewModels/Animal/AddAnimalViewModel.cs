﻿namespace VetSystem.Core.ViewModels.Animal
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using VetSystem.Core.ViewModels.Breed;

    public class AddAnimalViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Kilograms { get; set; }

        public int BreedId { get; set; }

        public string BreedName { get; set; }
    }
}