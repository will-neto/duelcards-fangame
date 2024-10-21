using Microsoft.EntityFrameworkCore;
using DuelCards.FanGame.Domain.Entities;

namespace DuelCards.FanGame.Data
{
    public class DuelCardsFanGameContext : DbContext
    {
        public DuelCardsFanGameContext(DbContextOptions<DuelCardsFanGameContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerCard> PlayerCards { get; set; }
        public DbSet<Card> Cards { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DuelCardsFanGameContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
