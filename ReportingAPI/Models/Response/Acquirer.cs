﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class Acquirer
    {
        public int id { get; set; }

        public string name { get; set; }

        public string code { get; set; }

        public string type { get; set; }
    }
}