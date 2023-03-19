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
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        // declare Dependency Injecktion "DI"
        public AccountController(UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }


        [HttpPost("register")] // api/account/register
        public async Task<IActionResult> Register(UserRegisterDto userDto) // RegisterUserDto it's class have registration data
        {
            if(ModelState.IsValid)
            {
                // create function don't take Dto, it's only take model so:
                AppUser user = new AppUser();
                user.UserName = userDto.username;
                user.PhoneNumber = userDto.phone;
                user.Email = userDto.email;
                user.PasswordHash = userDto.password;

                // save datat in database, by using Store if result true will save data
                // don't forget hash input password
                IdentityResult result = await _userManager.CreateAsync(user, userDto.password);
                
                if (result.Succeeded)
                {
                    string msg = "Registered Successfully.";
                    return Ok(new { msg });
                    //return Accepted();
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

        // check account valid or not
        [HttpPost("login")]  // api/account/login
        public async Task<IActionResult> Login(UserLoginDto userDto)
        {
            if (ModelState.IsValid)
            {
                // check if user is exist
                AppUser user = await _userManager.FindByNameAsync(userDto.username);

                // if user name is founded
                if (user != null)
                {
                    // talk password of User Login dto and hash password, compare by user  
                    bool foundUser = await _userManager.CheckPasswordAsync(user, userDto.password);

                    if (foundUser)
                    {
                        // claims => Token
                        var claims = new List<Claim>();

                        // to add claim ==> define type of claim and assign value 
                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));

                        // to make token is unique
                        claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

                        // get Roles 
                        var roles = await _userManager.GetRolesAsync(user);
                        foreach (var role in roles)
                        {
                            // if this claimm "role" is exist will put it in array
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }

                        // get JWT Token
                        var _TokenData = TokenData(claims);

                        // to return token
                        return Ok(new
                        {
                            // create Token or write Token
                            // give me instance of JwtSecurityTokenHandler
                            Token = new JwtSecurityTokenHandler().WriteToken(_TokenData),
                            Expiration = _TokenData.ValidTo
                        });
                    }
                }
                // user don't have valid account
                return Unauthorized();
            }
            // user don't have valid account
            return Unauthorized();
        }

        // get token data
        private JwtSecurityToken TokenData(List<Claim> claims)
        {
            // get security key
            SecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));
            // handle signature
            SigningCredentials signincred = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            // represent Token not create
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _config["JWT:ValidIssuer"],   //"http://localhost:8114/" url web api "Provider"
                audience: _config["JWT:ValidAudience"], //"http://localhost:4200/" url angular "Consumer"
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signincred
                );
            return token;
        }



        // add role for admins==> when make a registeration
        [HttpPost("role")]
        public async Task<IActionResult> AddRole([FromForm] UserRegisterDto userDto, string role)
        {

            if (ModelState.IsValid)
            {

                AppUser user = new AppUser();
                user.UserName = userDto.username;
                user.Email = userDto.email;
                user.PasswordHash = userDto.password;

                // check if role exist in database or not
                if (await _roleManager.RoleExistsAsync(role))
                {
                    IdentityResult result = await _userManager.CreateAsync(user, userDto.password);

                    if (result.Succeeded)
                    {
                        //add role to the user "Admin"
                        //// AddToRolesAsync==> take AppUser & string "Roles"
                        await _userManager.AddToRoleAsync(user, role);

                        return Ok($"Registered Successfully, and your rols is {role}."); // or Accepted();
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    return BadRequest("This Role Doesn't Exist.");
                }

            }
            return BadRequest(ModelState);
        }
    }
}
