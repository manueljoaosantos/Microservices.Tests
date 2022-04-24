namespace Core.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public Address Address { get; set; } = new Address();
    }
}