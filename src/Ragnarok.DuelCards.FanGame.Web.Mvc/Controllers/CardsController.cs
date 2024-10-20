using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ragnarok.DuelCards.FanGame.Data;
using Ragnarok.DuelCards.FanGame.Domain.Entities;
using Ragnarok.DuelCards.FanGame.Domain.Enum;

namespace Ragnarok.DuelCards.FanGame.Web.Mvc.Controllers
{
    [Route("cards")]
    public class CardsController : Controller
    {
        private readonly RagnarokDuelCardsContext _db;
        public CardsController(RagnarokDuelCardsContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.Set<Card>().ToListAsync());
        }
    }
}
