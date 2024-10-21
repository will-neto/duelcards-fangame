using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelCards.FanGame.Domain.Entities
{
    public class CardCollection : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BannerUrl { get; set; }
        public string BackgroundColor { get; set; }

        //TODO: incluir como Value Object/ Complex Type no EF??
        public CardCollection Status { get; set; }
        public DateTime StatusDate { get; set; }
        public List<Card> Cards { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
