using DuelCards.FanGame.Domain.Enum;

namespace DuelCards.FanGame.Domain.Entities
{
    public class Card : Entity
    {
        public string Name { get; set; } = null!;
        public Element Element { get; set; } = Element.Undefined;
        public int Damage { get; set; }
        public int Defense { get; set; }
        public bool IsBuff { get; set; }
        public Buff Buff { get; set; }

        public Guid CardCollectionId { get; set; }
        public CardCollection CardCollection { get; set; }

        public List<PlayerCard> PlayerCards { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
