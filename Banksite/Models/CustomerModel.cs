using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banksite.Models
{
    public class CustomerModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int SSN { get; set; }
        public string Adress { get; set; }
    }
}
