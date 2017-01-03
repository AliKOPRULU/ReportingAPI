using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class TransactionQueryResponse
    {
        public int perPage { get; set; }

        public int currentPage { get; set; }

        [StringLength(256)]
        public string newtPageUrl { get; set; }

        [StringLength(256)]
        public string prevPageUrl { get; set; }

        public int from { get; set; }

        public int to { get; set; }

        public IQueryable<TransactionQueryData> data { get; set; }
    }
}