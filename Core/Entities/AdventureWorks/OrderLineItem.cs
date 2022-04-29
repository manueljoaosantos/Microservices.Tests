using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.AdventureWorks
{
    public class OrderLineItem : BaseEntity
    {
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public Int16 OrderQty { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPriceDiscount { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal LineTotal { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTimeOffset CreatedOnUtc { get; set; }
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedOnUtc { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}