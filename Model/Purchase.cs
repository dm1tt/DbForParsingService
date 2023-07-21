
using System.ComponentModel.DataAnnotations;

namespace DatabaseSchema.Model; 

public class Purchase
{
    [Required]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string PurchaseStatementId { get; set; }

    public PurchaseStatement PurchaseStatement { get; set; } = null!;

    public required string ProductLinkId { get; set; }

    public ProductLink ProductLink { get; set; } = null!;

    public int Count { get; set; }

    public string Name { get; set; }

}
