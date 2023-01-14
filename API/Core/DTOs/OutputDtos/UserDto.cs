// when the client has successfully logged in or registered 
namespace Eventsocity.API.Core.DTOs.OutputDtos;

public class UserDto 
{
   public string DisplayName { get; set; }
   public string Username { get; set; }
   public string Token { get; set; }
   public string Image { get; set; }
}