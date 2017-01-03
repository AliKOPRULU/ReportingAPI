using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class MerchantResponse
    {
        public string token { get; set; }

        [StringLength(64)]
        public string status { get; set; }
    }
}