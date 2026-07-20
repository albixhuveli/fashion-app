using Microsoft.AspNetCore.Mvc;
using FashionApp.API.Models;
using FashionApp.API.Data;

namespace FashionApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClothingController : ControllerBase
{   
    private readonly FashionDbContext _context;
    public ClothingController(FashionDbContext context)
{
    _context = context;
}

    [HttpGet]
    public ActionResult<List<ClothingItem>> GetAll()
    {
        return Ok(_context.ClothingItems.ToList());
    }

    [HttpPost]
    public ActionResult<ClothingItem> AddClothing(ClothingItem clothingItem)
    {
        _context.ClothingItems.Add(clothingItem);
        _context.SaveChanges();
        return Ok(clothingItem);
    }
}