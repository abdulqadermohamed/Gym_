using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gym_.Data
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<UserSubscription> Subscriptions { get; set; }

    }
}
