namespace FashionApp.API.Models;

public class ClothingItem
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Category { get; set; } = "";

    public string Color { get; set; } = "";

    public string ImageUrl { get; set; } = "";
}