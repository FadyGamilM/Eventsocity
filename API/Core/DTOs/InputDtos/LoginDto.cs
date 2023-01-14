// when user need to login  [Input DTO]
namespace Eventsocity.API.Core.DTOs.InputDtos;

public class LoginDto
{
   public string Email { get; set; }
   public string Password { get; set; }
}