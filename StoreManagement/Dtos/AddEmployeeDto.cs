using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Dtos
{
    public class AddEmployeeDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public string ConfirmPassword { get; set; }
        public bool Receive { get; set; }
        public bool Stow { get; set; }
        public bool Pick { get; set; }
        public bool Pack { get; set; }
        public bool Ship { get; set; }
    }
}