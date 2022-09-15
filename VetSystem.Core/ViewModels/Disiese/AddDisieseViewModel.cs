namespace VetSystem.Core.ViewModels.Disiese
{
    using System.Collections.Generic;
    using VetSystem.Infrastucture.Data.Models;

    public class AddDisieseViewModel
    {

        public AddDisieseViewModel(List<string> list)
        {
            this.DiseaseCategoryName = list;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int DiseaseCategoryId { get; set; }

        public List<string> DiseaseCategoryName { get; set; }

    }
}
