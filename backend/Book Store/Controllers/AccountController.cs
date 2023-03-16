using Book_Store.DTOs.AccountDTOs;
using Book_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Book_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _config;

        // declare Dependency Injecktion "DI"
        public AccountController(UserManager<AppUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }


        [HttpPost("register")] // api/account/register
        public async Task<IActionResult> Register(UserRegisterDto userDto) // RegisterUserDto it's class have registration data
        {
            if(ModelState.IsValid)
            {
                // create function don't take Dto, it's only take model so:
                AppUser user = new AppUser();
                user.UserName = userDto.userName;
                user.Email = userDto.email;
                user.PasswordHash = userDto.password;

                // save datat in database, by using Store if result true will save data
                // don't forget hash input password
                IdentityResult result = await _userManager.CreateAsync(user, userDto.password);
                
                if (result.Succeeded)
                {
                    return Ok("Registered Successfully.");    //Accepted();
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            // if model is invalid
            return BadRequest(ModelState);
        }

       
    }
}
