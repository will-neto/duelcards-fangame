using DuelCards.FanGame.Domain.Enum;

namespace DuelCards.FanGame.Domain.Entities
{
    public class Tag : Entity
    {
        public int TagName { get; set; }
        public Guid OriginId { get; set; }
        public TagType Type { get; set; }
    }
}
