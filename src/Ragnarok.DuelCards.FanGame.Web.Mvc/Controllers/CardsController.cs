using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ragnarok.DuelCards.FanGame.Data;
using Ragnarok.DuelCards.FanGame.Domain.Entities;

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

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cards = await _db.Set<Card>().ToListAsync();
            return View(cards);
        }

        [HttpGet("edit/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var card = await _db.Set<Card>().FindAsync(id);
            return View(card);
        }
    }
}
