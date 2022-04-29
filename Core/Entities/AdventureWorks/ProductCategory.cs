using System.ComponentModel.DataAnnotations;

namespace Core.Entities.AdventureWorks
{
    public class ProductCategory : BaseEntity
    {
    public ProductCategory()
    {
      Products = new HashSet<Product>();
    }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
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