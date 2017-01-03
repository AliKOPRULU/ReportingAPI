using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Post
{
    public class TransactionReport
    {
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = ("{0:yyyy-MM-dd}"))]
        public DateTime fromDate { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = ("{0:yyyy-MM-dd}"))]
        public DateTime toDate { get; set; }

        public int merchant { get; set; }

        public int acquirer { get; set; }
    }
}