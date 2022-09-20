namespace VetSystem.Core.ViewModels.DiseaseCategory
{
    public class AddDiseaseCategoryServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DiseaseCategoryId { get; set; }

        public DiseaseCategoryViewDataModel DiseaseCategories { get; set; }
    }
}
