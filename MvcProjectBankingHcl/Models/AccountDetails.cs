using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectBankingHcl.Models
{
    public class AccountDetails
    {
        public string AccountDetailsId { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode{ get; set; }
        public string BankBranch { get; set; }
    }
}