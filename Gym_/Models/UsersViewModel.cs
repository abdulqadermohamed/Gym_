using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym_.Models
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string Subscription { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
