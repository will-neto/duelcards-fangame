using Microsoft.AspNetCore.Mvc;
using DuelCards.FanGame.Data;
using DuelCards.FanGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DuelCards.FanGame.Web.Mvc.Controllers
{
    [Route("cards")]
    public class CardsController : Controller
    {
        private readonly DuelCardsFanGameContext _db;
        public CardsController(DuelCardsFanGameContext db)
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
