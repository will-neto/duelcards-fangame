using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelCards.FanGame.Domain.Entities
{
    public class Player : Entity
    {
        public string Username { get; set; } = null!;
        public long Level { get; set; } 
        public List<PlayerCard> PlayerCards { get; set; }
        public DateTime SignInDate { get; set; }
        public DateTime BlockedDate { get; set; }
    }
}

