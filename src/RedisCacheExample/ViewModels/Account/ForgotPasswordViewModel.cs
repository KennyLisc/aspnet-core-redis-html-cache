using System.ComponentModel.DataAnnotations;

namespace RedisCacheExample.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
