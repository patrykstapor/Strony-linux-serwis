using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Strony.Models
{
    public class User
    {
        public int Id { get; set;}

        [DisplayName ("Login")]
        [Required]
        public string Name { get; set; }

        [DisplayName ("Hasło")]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public bool Logged { get; set; }
    }
}
