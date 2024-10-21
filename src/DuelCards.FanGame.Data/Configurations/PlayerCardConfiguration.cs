using DuelCards.FanGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuelCards.FanGame.Data.Configurations
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
