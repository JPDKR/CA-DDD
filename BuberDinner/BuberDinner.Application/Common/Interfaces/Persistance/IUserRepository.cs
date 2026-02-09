using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void AddUserAsync(User user);
}