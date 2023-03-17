using System.ComponentModel.DataAnnotations;

namespace FlexMoney.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}