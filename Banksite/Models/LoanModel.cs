using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banksite.Models
{
    public class LoanModel
    {
        public string Id { get; set; }
        public int Balance { get; set; }
        public int LoanType { get; set; }
        public DateTime PayByDate { get; set; }
        public BranchModel Branch { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
