

namespace Clinic.Application.Auth
{
    public interface IAuthService
    {
        Task<AuthResult> LoginAsync(LoginRequest request);
        Task<AuthResult> RegisterAsync(RegisterRequest request);
    }
}
