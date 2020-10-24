using System.ComponentModel.DataAnnotations;

namespace Shopping_Web.Models.UserModel
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Email Address is Invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
