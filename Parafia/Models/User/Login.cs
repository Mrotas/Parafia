using System.ComponentModel.DataAnnotations;

namespace Parafia.Models.User
{
    public class Login
    {
        [Required(ErrorMessage = "Podaj email")]
        public string Email { get; set; }

        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Podaj hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj hasło")]
        public bool RememberMe { get; set; }
    }
}