using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWpf.Models
{
   public class Subscription
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public int AddressId { get; set; }
    }
}
