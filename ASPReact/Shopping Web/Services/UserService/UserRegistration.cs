using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shopping_Web.Controllers;
using Shopping_Web.DbContexts;
using Shopping_Web.Models;

namespace Shopping_Web.Services.UserService
{
    public class UserRegistration
    {
        private UserModel user = new UserModel();
        private UserController _controller;

        public UserRegistration (UserController controller)
        {
            _controller = controller;
        }

        public UserModel RegisterUser(string name, string email, string password)
        {
            user.Name = name;
            user.Email = email;
            user.Password = SecurePasswordHasher.Hash(password);

            return user;
        }

        public bool CheckEmail(string email)
        {
            return true;
        }
    }
}
