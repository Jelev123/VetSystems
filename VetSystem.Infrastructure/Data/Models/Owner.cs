namespace VetSystem.Infrastucture.Data.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public ICollection<Animal> Animals { get; set; } = new HashSet<Animal>();
    }
}
