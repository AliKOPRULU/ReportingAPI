using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Post
{
    public class Merchant
    {
        [StringLength(128)]
        public string email { get; set; }

        [StringLength(32)]
        public string password { get; set; }
    }
}