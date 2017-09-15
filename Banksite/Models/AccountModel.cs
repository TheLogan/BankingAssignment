using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banksite.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public int AccountType { get; set; }
        public int Balance { get; set; }
        public BranchModel Branch { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
