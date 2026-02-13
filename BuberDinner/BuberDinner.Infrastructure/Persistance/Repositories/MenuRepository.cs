using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Menus;

namespace BuberDinner.Infrastructure.Persistance.Repositories;

public class MenuRepository(BuberDinnerDbContext context) : IMenuRepository
{
    private readonly BuberDinnerDbContext _context = context;

    public void Add(Menu menu)
    {
        _context.Add(menu);
        _context.SaveChanges();
    }
}