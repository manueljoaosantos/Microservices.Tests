using System.ComponentModel.DataAnnotations;

namespace Core.Entities.AdventureWorks
{
    public class ProductModel : BaseEntity
    {
    public ProductModel()
    {
      Products = new HashSet<Product>();
    }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    [Required]
    [MaxLength(320)]
    public string CreatedBy { get; set; }
    [Required]
    public DateTimeOffset CreatedOnUtc { get; set; }
    [MaxLength(320)]
    public string UpdatedBy { get; set; }
    public DateTimeOffset? UpdatedOnUtc { get; set; }
    public virtual ICollection<Product> Products { get; }
    }
}