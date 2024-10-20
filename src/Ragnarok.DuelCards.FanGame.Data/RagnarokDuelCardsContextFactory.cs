using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok.DuelCards.FanGame.Data
{
    public class RagnarokDuelCardsContextFactory : IDesignTimeDbContextFactory<RagnarokDuelCardsContext>
    {
        public RagnarokDuelCardsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RagnarokDuelCardsContext>();

            optionsBuilder.UseSqlServer("Server=localhost;Database=RagnarokDuelCardsDB;User Id=sa;Password=Senh@2024***;TrustServerCertificate=True;");

            return new RagnarokDuelCardsContext(optionsBuilder.Options);
        }
    }
}
