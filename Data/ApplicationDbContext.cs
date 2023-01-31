using Microsoft.EntityFrameworkCore;
using RazorPiezzeria.Models;

namespace RazorPiezzeria.Data;

#pragma warning disable
public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _config;

    public ApplicationDbContext(IConfiguration config)
    {
        _config = config;
    }

    public DbSet<PizzaOrder> PizzaOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connString = _config.GetConnectionString("DefaultConnection");
        if (connString is null)
            throw new Exception();

        options.UseMySql(connString, ServerVersion.AutoDetect(connString));
    }
}