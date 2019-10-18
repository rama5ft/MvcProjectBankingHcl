using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectBankingHcl.Models
{
    public class Transactions
    {
      [Key]
        public int TransactionId { get; set; }
        public DateTime TransactionTimeAndDate { get; set; }
        public Double Amount { get; set; }
        public string TransactionType { get; set; }
    }
}