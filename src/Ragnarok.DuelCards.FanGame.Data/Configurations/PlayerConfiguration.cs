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
