using DuelCards.FanGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuelCards.FanGame.Data.Configurations
{
    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>

    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Player");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Username)
                .IsRequired()
                .HasColumnType("nvarchar(16)");

            builder.Property(p => p.Level)
                .IsRequired();
        }
    }
}
