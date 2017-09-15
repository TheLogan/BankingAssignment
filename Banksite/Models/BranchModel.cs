using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banksite.Models
{
    public class BranchModel
    {
        public string Id { get; set; }
        public BankCoreModel BankCore { get; set; }
        public string BranchName { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string Adress { get; set; }
    }
}
