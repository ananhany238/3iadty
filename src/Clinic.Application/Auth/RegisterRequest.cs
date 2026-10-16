using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application.Auth
{
    public record RegisterRequest
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; init; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; init; } = string.Empty;

        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; init; } = string.Empty;
    }
}