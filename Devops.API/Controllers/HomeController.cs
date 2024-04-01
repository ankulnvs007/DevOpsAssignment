using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devops.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("{GuessNumber}")]
        public string Get(int GuessNumber) 
        {
            if (GuessNumber < 100)
            {
                return "Wrong ! Try a larger number.";
            }
            else if (GuessNumber > 100)
            {
                return "Wrong ! Try a smaller number.";
            }
            else
            {
                return "You guessed correct number.";
            }
        }
    }
}
