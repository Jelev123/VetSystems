namespace VetSystem.Core.ViewModels.Disiese
{
    using VetSystem.Infrastucture.Data.Models;

    public class AddDisieseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DiseaseCategoryId { get; set; }

    }
}
