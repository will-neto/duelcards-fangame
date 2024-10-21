using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelCards.FanGame.Domain.Enum
{
    public enum CardCollectionStatus : short
    {
        Activated = 0,
        Maintaining,
        Disabled,
        Removed,

    }
}
