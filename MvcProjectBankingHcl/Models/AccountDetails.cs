using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectBankingHcl.Models
{
    public class AccountDetails
    {
        [Key]
        public string AccountDetailsId { get; set; }
      //  public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode{ get; set; }
        public string BankBranch { get; set; }
        public int AccountType { get; set; }



        //Referencing table from accountHolder
           public AccountHolderDetails AccountHolderDetails { get; set; }
        //referencing column
        public int?AccountHolderDetailsid { get; set; }
    }
}