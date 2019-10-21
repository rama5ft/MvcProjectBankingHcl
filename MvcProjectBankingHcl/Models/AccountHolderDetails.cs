                                                                                                       using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectBankingHcl.Models
{
    public class AccountHolderDetails
    {
        [Key]
        public int AccountHolderDetailsId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public string AccountHolderName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string  MobileNumber { get; set; }
        public string AlternateMobileNumber { get; set; }
        public string EmailId { get; set; }
      //  public int MyProperty { get; set; }
        public List<string> Nationality { get; set; }
        public string Address { get; set; }
        public byte[] IdProofs { get; set; }
        public string Status { get; set; }
    }
}