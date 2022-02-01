using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym_.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "This filed is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This filed is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This filed is required")]
        public string Password { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
