using Eventsocity.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Eventsocity.API.Core.DTOs.InputDtos;
using Eventsocity.API.Core.DTOs.OutputDtos;

namespace Eventsocity.API.Controllers;

[Route("api/users")]
public class AccountsController : BaseController
{
   private readonly UserManager<User> _userManager;
   public AccountsController(UserManager<User> userManager) : base(null)
   {
      _userManager = userManager;
   }
   [HttpGet]
   public async Task<IActionResult> SayHello()
   {
      return Ok("helllo");
   }

   [HttpPost("login")]
   public async Task<IActionResult> Login([FromBody] LoginDto userLogin)
   {
      // check if there is a user with the given email
      var user = await _userManager.FindByEmailAsync(userLogin.Email);

      // if not, return not authorized
      if(user == null)
         return Unauthorized();

      // if its found
      // => check the password if its the right pass
      var IsPassMatches = await _userManager.CheckPasswordAsync(user, userLogin.Password);

      // ==> if it does not matche, return unauthorized
      if(IsPassMatches == false)
         return Unauthorized();  

      // ==> if it matches, returns the UserDto with required info
      return Ok(
         new UserDto{
            DisplayName=user.DisplayName,
            Username=user.UserName,
            Image=null,
            Token="Will be a token"
         }
      );
   }
}