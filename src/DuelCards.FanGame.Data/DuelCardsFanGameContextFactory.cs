using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelCards.FanGame.Data
{
    public class DuelCardsFanGameContextFactory : IDesignTimeDbContextFactory<DuelCardsFanGameContext>
    {
        public DuelCardsFanGameContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DuelCardsFanGameContext>();

            optionsBuilder.UseSqlServer("Server=localhost;Database=DuelCardsFanGameDB;User Id=sa;Password=Senh@2024***;TrustServerCertificate=True;");

            return new DuelCardsFanGameContext(optionsBuilder.Options);
        }
    }
}
