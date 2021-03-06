using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core.Entities.AdventureWorks
{
    public class Customer : BaseEntity
    {    

/*        [Required]
        public Guid Id { get; set; }*/
        [Required]
        [MinLength(10)]
        [MaxLength(15)]
        public string Num { get; set; }  
        [MaxLength(512)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string CompanyName { get; set; }
        [Required]
        public int SalesAgentId { get; set; }
        [MaxLength(250)]
        public string EmailAddress { get; set; }
        [MaxLength(25)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTimeOffset CreatedOnUtc { get; set; }
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedOnUtc { get; set; }
        public virtual SalesAgent SalesAgent { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; }
        public virtual ICollection<Order> Orders { get; }

        public Customer()
        {
            Num = String.Empty;
            Name = String.Empty;
            CompanyName = String.Empty;
            EmailAddress= String.Empty;
            Phone= String.Empty;
            CreatedBy= String.Empty;
            UpdatedBy= String.Empty;
            SalesAgent = new SalesAgent();
            CustomerAddresses = new HashSet<CustomerAddress>();
            Orders = new HashSet<Order>();
        }
    }
}