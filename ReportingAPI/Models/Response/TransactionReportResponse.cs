using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class TransactionReportResponse
    {
        [StringLength(64)]
        public string status { get; set; }

        public IQueryable<TransactionReport> transactionReport { get; set; }//IQueryable, belli bir uzak veri kaynağından(web service,database…) verileri sorgulamak için işlevsellik sağlar
        //http://melihorhan.com/ienumerable-ve-iqueryable-arasindaki-farklar-nelerdir/
    }
}