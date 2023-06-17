using IService;
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
        private readonly IUserService _UserService;
        public AccountController(IUserService UserService)
        {
            _UserService = UserService;
        }

        [HttpPost]
        public IActionResult GetListAll()
        {

            var result = _UserService.GetListAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
        [HttpGet("{Account},{Password}")]
        public IActionResult GetListById(string Account, string Password)
        {

            if (Account == "" || Password == "")
            {
                return BadRequest();
            }
            var query = _UserService.QueryByID(Account, Password);
            if (query == null)
            {
                return NotFound();
            }

            return Ok(query);
        }

        [HttpPost("Gid")]
        public IActionResult Create(string Gid, User Data)
        {
            if (ModelState.IsValid)
            {
                if (Gid == "") Data.Guid = Guid.NewGuid().ToString();
                var result = _UserService.Create(Data);
                if (result)
                {
                    return NoContent();
                }
                return BadRequest();
            }

            return BadRequest();
        }

        [HttpDelete("{Account},{Password}")]
        public IActionResult Delete(string Account, string Password)
        {
            if (Account == "" || Password == "")
            {
                return BadRequest();
            }
            var result = _UserService.Delete(Account, Password);
            if (result)
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
