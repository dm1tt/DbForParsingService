
using System.ComponentModel.DataAnnotations;

namespace DatabaseSchema.Model;

public class PurchaseStatement
{
    [Required]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string OrderNumber { get; set; }

    public required string UserId { get; set; }

    public User User { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public Purchase? Purchase { get; set; }
}
