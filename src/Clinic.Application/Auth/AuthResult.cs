using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application.Auth
{
    public record AuthResult
    {
        public string Token { get; init; } = string.Empty;
        public DateTime ExpiresAt { get;} = DateTime.UtcNow;

        public string Role { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;

    }
}
