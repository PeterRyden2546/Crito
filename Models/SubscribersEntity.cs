using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class SubscribersEntity
{
    [Key]
    public string Email { get; set; } = null!;
}
