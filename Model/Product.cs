
using System.ComponentModel.DataAnnotations;

namespace DatabaseSchema.Model;

public class Product
{
    [Required]
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public string ProductType { get; set; }

    public ICollection<ProductLink> ProductLinks { get; } = new List<ProductLink>();
}

