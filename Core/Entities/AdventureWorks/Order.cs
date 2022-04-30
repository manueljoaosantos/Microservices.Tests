using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.AdventureWorks
{
    public class Order : BaseEntity
    {
        public int OrderId { get; set; }
        [Required]
        public byte RevisionNum { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        [Required]
        public byte Status { get; set; }
        [Required]
        public bool IsOnlineOrder { get; set; }
        [Required]
        [MaxLength(25)]
        public string Num { get; set; }
        [MaxLength(25)]
        public string PurchaseOrderNum { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        public Guid? ShipToAddressId { get; set; }
        public Guid? BillToAddressId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ShipMethod { get; set; }
        [MaxLength(15)]
        public string CreditCardApprovalCode { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal SubTotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TaxAmt { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Freight { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalDue { get; set; }
        [MaxLength(500)]
        public string Comment { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTimeOffset CreatedOnUtc { get; set; }
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedOnUtc { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual OrderAddress ShipToAddress { get; set; }

        // public virtual OrderAddress BillToAddress { get; set; }
        public virtual ICollection<OrderLineItem> OrderLineItems { get; }

        public Order()
        {
            this.Num = String.Empty;
            this.ShipMethod = String.Empty;
            PurchaseOrderNum= String.Empty;
            CreditCardApprovalCode = String.Empty;
            Comment = String.Empty;
            CreatedBy = String.Empty;
            UpdatedBy = String.Empty;
            Customer = new Customer();
            ShipToAddress = new OrderAddress();
            OrderLineItems = new HashSet<OrderLineItem>();

        }
    }
}