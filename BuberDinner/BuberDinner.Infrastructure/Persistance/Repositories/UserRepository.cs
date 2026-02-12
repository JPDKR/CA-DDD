using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Users;

namespace BuberDinner.Infrastructure.Persistance.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = [];

     public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
}