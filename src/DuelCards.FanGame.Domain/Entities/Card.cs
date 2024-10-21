using DuelCards.FanGame.Domain.Enum;

namespace DuelCards.FanGame.Domain.Entities
{
    public class Card : DuelCards
    {
        public string Name { get; set; } = null!;
        public Element Element { get; set; } = Element.Undefined;
        public int Damage { get; set; }
        public int Defense { get; set; }
        public bool IsBuff { get; set; }
        public Buff Buff { get; set; }

        public List<PlayerCard> PlayerCards { get; set; }
    } 
}
