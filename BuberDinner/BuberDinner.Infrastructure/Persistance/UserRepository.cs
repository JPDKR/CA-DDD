using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Infrastructure.Persistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = [];

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }

    public void AddUserAsync(User user)
    {
        _users.Add(user);
    }
}