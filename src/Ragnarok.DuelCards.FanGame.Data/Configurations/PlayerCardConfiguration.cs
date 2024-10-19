using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ragnarok.DuelCards.FanGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok.DuelCards.FanGame.Data.Configurations
{
    internal class PlayerCardConfiguration : IEntityTypeConfiguration<PlayerCard>

    {
        public void Configure(EntityTypeBuilder<PlayerCard> builder)
        {
            builder.ToTable("PlayerCard");

            builder.HasKey(p => new { p.Id, p.PlayerId, p.CardId });

            builder.HasOne(pc => pc.Player)
                .WithMany(p => p.PlayerCards)
                .HasForeignKey(pc => pc.PlayerId);

            builder.HasOne(pc => pc.Card)
                .WithMany(c => c.PlayerCards)
                .HasForeignKey(pc => pc.CardId);
        }
    }
}
