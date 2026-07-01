using Microsoft.EntityFrameworkCore;
using FashionApp.API.Models;

namespace FashionApp.API.Data;

public class FashionDbContext: DbContext
{
    public FashionDbContext(DbContextOptions<FashionDbContext> options) 
        : base(options)
    {    
    }

    public DbSet<ClothingItem> ClothingItems {get ; set;}
}
