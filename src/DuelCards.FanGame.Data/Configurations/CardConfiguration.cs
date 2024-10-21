using DuelCards.FanGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuelCards.FanGame.Data.Configurations
{
    internal class CardConfiguration : IEntityTypeConfiguration<Card>

    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Card");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(p => p.Damage)
                .IsRequired();

            builder.Property(p => p.Defense)
                .IsRequired();

            builder.Property(p => p.IsBuff)
                .IsRequired();

            builder.Property(p => p.Buff)
                .IsRequired();
        }
    }
}
