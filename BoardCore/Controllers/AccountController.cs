﻿using IService;
using Microsoft.AspNetCore.Mvc;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IUserService _Productsvc;
        public AccountController (IUserService UserService)
        {
            _Productsvc = UserService;
        }
        //隨便亂玩
        [HttpGet]
        public IActionResult Login(string ID , string Password)
        {
            
            var x = _Productsvc.GetById(ID, Password);
            return View();

        
        }
    }
}
