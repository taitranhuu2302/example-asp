namespace Example.Models;

public class Contact : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string NumberPhone { get; set; } = null!;
    public string Country { get; set; } = null!;
}