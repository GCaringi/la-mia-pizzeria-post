namespace la_mia_pizzeria_post.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
}