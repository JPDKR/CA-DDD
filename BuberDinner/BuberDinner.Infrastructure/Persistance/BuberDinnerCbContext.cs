using BuberDinner.Domain.Menus;
using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistance;

public class BuberDinnerCbContext(DbContextOptions<BuberDinnerCbContext> options) : DbContext(options)
{
    public DbSet<Menu> Menus { get; set; } = null!;


protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(BuberDinnerCbContext).Assembly); 

        base.OnModelCreating(modelBuilder);   
    }
}