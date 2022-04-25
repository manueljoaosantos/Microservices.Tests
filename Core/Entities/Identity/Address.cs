using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; } //= String.Empty;
        public string LastName { get; set; } //= String.Empty;
        public string Street { get; set; } //= String.Empty;
        public string City { get; set; } //= String.Empty;
        public string State { get; set; } //= String.Empty;
        public string ZipCode { get; set; } //= String.Empty;

        [Required]
        public string AppUserId { get; set; } //= String.Empty;
        public AppUser AppUser { get; set; } //= new AppUser();
    }
}