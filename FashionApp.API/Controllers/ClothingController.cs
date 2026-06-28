using Microsoft.AspNetCore.Mvc;
using FashionApp.API.Models;

namespace FashionApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClothingController : ControllerBase
{
    private static List<ClothingItem> clothingItems = new()
    {
        new ClothingItem
        {
            Id = 1,
            Name = "Black Hoodie",
            Category = "Top",
            Color = "Black",
            ImageUrl = ""
        }
    };

    [HttpGet]
    public ActionResult<List<ClothingItem>> GetAll()
    {
        return Ok(clothingItems);
    }

    [HttpPost]
    public ActionResult<ClothingItem> AddClothing(ClothingItem clothingItem)
    {
        clothingItem.Id = clothingItems.Count + 1;
        clothingItems.Add(clothingItem);
        return Ok(clothingItem);
    }
}