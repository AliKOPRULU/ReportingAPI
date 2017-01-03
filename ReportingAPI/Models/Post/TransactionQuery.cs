using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Post
{
    public class TransactionQuery
    {
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = ("{0:yyyy-MM-dd}"))]
        public DateTime fromDate { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = ("{0:yyyy-mm-dd}"))]
        public DateTime toDate { get; set; }

        [StringLength(64)]
        public string status { get; set; }

        [StringLength(64)]
        public string operataion { get; set; }

        public int merchantId { get; set; }

        public int acquirerId { get; set; }

        [StringLength(32)]
        public string paymentMethod { get; set; }

        [StringLength(256)]
        public string errorCode { get; set; }

        [StringLength(128)]
        public string filterField { get; set; }

        [StringLength(128)]
        public string filterValue { get; set; }

        public int page { get; set; }
    }
}