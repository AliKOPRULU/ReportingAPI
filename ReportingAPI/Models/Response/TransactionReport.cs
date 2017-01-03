using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class TransactionReport
    {
        public int count { get; set; }

        public int total { get; set; }

        [StringLength(3)]
        public string currency { get; set; }
    }
}