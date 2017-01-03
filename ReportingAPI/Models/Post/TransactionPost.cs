using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Post
{
    public class TransactionPost
    {
        [StringLength(32)]
        public int transactionId { get; set; }
    }
}