using Ragnarok.DuelCards.FanGame.Domain.Enum;

namespace Ragnarok.DuelCards.FanGame.Domain.Entities
{
    public class Card : Entity
    {
        public string Name { get; set; } = null!;
        public Element Element { get; set; } = Element.Undefined;
        public int Damage { get; set; }
        public int Defense { get; set; }
        public bool IsBuff { get; set; }
        public Buff Buff { get; set; }
    }
}
