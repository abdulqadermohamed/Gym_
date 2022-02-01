using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym_.Data
{
    public class UserSubscription
    {
        [Key]
        public int Id { get; set; }
        public int SubScription_ID { get; set; }
        public int User_id { get; set; }
        public int Duration { get; set; } //3 months

        public double Price { get; set; }
        [ForeignKey(nameof(User_id))]
        public User User { get; set; }

        [ForeignKey(nameof(SubScription_ID))]
        public Subscription Subscription { get; set; }
    }
}
