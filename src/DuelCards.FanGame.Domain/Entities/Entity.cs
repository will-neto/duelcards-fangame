namespace DuelCards.FanGame.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid UpdatedUserId { get; set; }
        public DateTime UpdatedDateTime { get; set; }

    }
}
