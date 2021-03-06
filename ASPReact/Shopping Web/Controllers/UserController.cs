﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping_Web.DbContexts;
using Shopping_Web.Models;
using Shopping_Web.Services.UserService;

namespace Shopping_Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ShoppingContext _context;
        public UserRegistration _registration;



        public UserController(ILogger<ProductController> logger, ShoppingContext context, UserRegistration registration)
        {
            _logger = logger;
            _context = context;
            _registration = registration;
        }


        [HttpPost("api/user/register")]
        public async Task<ActionResult<UserModel>> PostUserInfo(UserModel userInfo)
        {
            userInfo = _registration.RegisterUser(userInfo.Name, userInfo.Email, userInfo.Password);

            if (userInfo == null)
            {

            }
            _context.User.Add(userInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = userInfo.Id}, userInfo);
        }

        [HttpGet("api/user/id/{id}")]
        public async Task<ActionResult<UserModel>> GetUserById(int id)
        {
            var userInfo = await _context.User.FindAsync(id);

            if (userInfo == null) return NotFound();

            return userInfo;
        }

        [HttpGet("api/user/email/{email}")]
        public async Task<ActionResult<UserModel>> GetUserByEmail(string email)
        {
            var userInfo = await _context.User.FindAsync(email);

            if (userInfo == null) return NotFound();

            return userInfo;
        }

    }
}
