using System.ComponentModel.DataAnnotations;

namespace Core.Entities.AdventureWorks
{
    public class CustomerAddress : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string AddressType { get; set; }
        [Required]
        [MaxLength(60)]
        public string Line1 { get; set; }
        [MaxLength(60)]
        public string Line2 { get; set; }
        [Required]
        [MaxLength(30)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string StateProvince { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryRegion { get; set; }
        [Required]
        [MaxLength(15)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTimeOffset CreatedOnUtc { get; set; }
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedOnUtc { get; set; }
        public virtual Customer Customer { get; set; }

        public CustomerAddress()
        {
            AddressType = String.Empty;
            Line1 = String.Empty;
            Line2 = String.Empty;
            City= String.Empty;
            StateProvince = String.Empty;
            CountryRegion = String.Empty;
            PostalCode = String.Empty;
            CreatedBy = String.Empty;
            UpdatedBy = String.Empty;
            Customer = new Customer();
        }
    }
}