using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym_.Data
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public int TypeOfUser { get; set; }


        public bool IsActive { get; set; }
        public List<UserSubscription> Subscriptions { get; set; }
    }
}
