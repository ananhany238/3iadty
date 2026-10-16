

namespace Clinic.Application.Auth
{
    public interface IJwtTokenGenerator
    {

        (string Token, DateTime ExpiresAt) GenerateToken(string userId, string email, string role);
    }
}