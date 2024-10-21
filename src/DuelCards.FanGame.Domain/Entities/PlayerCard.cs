using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelCards.FanGame.Domain.Entities
{
    public class PlayerCard : Entity
    {
        public Guid PlayerId { get; set; }
        public Guid CardId { get; set; }
        
        public Player Player  { get; set; }
        public Card Card { get; set; }
    }
}
