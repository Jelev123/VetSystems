﻿namespace VetSystem.Core.ViewModels.Disiese
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using VetSystem.Core.ViewModels.DiseaseCategory;
    using VetSystem.Infrastucture.Data.Models;

    public class AddDisieseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DiseaseCategories { get; set; }


    }
}
