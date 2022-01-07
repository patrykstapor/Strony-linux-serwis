using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strony.Models
{
    public class ViewModel
    {

        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Website> Websites { get; set; }

        public string GetName(User u)


        {

            return u.Name;
        }
    }
}
