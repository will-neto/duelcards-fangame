using Microsoft.EntityFrameworkCore;
using Ragnarok.DuelCards.FanGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok.DuelCards.FanGame.Data
{
    public class RagnarokDuelCardsContext : DbContext
    {
        public RagnarokDuelCardsContext(DbContextOptions<RagnarokDuelCardsContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerCard> PlayerCards { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RagnarokDuelCardsContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
