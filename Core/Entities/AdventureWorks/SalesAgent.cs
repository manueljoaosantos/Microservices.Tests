using System.ComponentModel.DataAnnotations;

namespace Core.Entities.AdventureWorks
{
    public class SalesAgent : BaseEntity
    {
        public SalesAgent()
        {
            Customers = new HashSet<Customer>();
        }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string LoginId { get; set; }
        public virtual ICollection<Customer> Customers { get; }
    }
}