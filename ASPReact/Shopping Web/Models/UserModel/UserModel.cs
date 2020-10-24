using System.ComponentModel.DataAnnotations;

namespace Shopping_Web.Models.UserModel
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [EmailAddress] 
        public string Email { get; set; }

        public string Password { get; set; }
    }
}