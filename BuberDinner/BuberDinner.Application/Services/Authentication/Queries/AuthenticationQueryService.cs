using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Common.Errors;
using BuberDinner.Domain.Entities;
using ErrorOr;

namespace BuberDinner.Application.Services.Authentication.Queries;

public class AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository) : IAuthenticationQueryService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;
    private readonly IUserRepository _userRepository = userRepository;

    public ErrorOr<AuthenticationResult> Login(string email, string password)
    {
        // Check if users already exists
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
           return Errors.Authentication.InvalidCredentials;
        }

        // Validates the password is correct
        if (user.Password != password)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // Create JWT Token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
}