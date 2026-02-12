using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menus;
using BuberDinner.Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistance;

public class BuberDinnerCbContext(DbContextOptions<BuberDinnerCbContext> options, PublishDomainEventsInterceptor publishDomainEventsInterceptor) : DbContext(options)
{
    private readonly PublishDomainEventsInterceptor _publish = publishDomainEventsInterceptor;
    public DbSet<Menu> Menus { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(BuberDinnerCbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_publish);
        base.OnConfiguring(optionsBuilder);
    }
}