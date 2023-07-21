using System.ComponentModel.DataAnnotations;

namespace DatabaseSchema.Model;

public class User
{
    [Required]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Password { get; set; }

    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public PurchaseStatement? PurchaseStatement { get; set; }
}
