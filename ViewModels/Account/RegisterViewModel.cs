using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentitySample.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Username")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
