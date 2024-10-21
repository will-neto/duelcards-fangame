using Microsoft.AspNetCore.Mvc;

namespace DuelCards.FanGame.WebGame.API.Controllers
{
    [ApiController]
    [Route("/collections")]
    public class CardController : ControllerBase
    {
        [HttpGet("collections")]
        public async Task<IActionResult> Collections()
        {
            await Task.FromResult(0);

            return Ok();
        }
    }
}
