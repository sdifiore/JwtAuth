using JwtAuth.Data;
using JwtAuth.Entities;
using JwtAuth.Models;

namespace JwtAuth.Services
{
    public class AuthService(UserDbContext context, ) : IAuthService
    {
        public Task<User?> RegisterAsync(UserDto request)
        {
            // Implementation for user registration
            throw new NotImplementedException();
        }

        public Task<User?> LoginAsync(UserDto request)
        {
            // Implementation for user login
            throw new NotImplementedException();
        }
    }
}