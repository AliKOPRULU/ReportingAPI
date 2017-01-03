using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class Merchant
    {
        private int id { get; set; }

        private String name { get; set; }

        private int parentId { get; set; }

        [JsonProperty("3dStatus")]
        private String threeDStatus { get; set; }

        private String mcc { get; set; }

        private String ipnUrl { get; set; }

        private String apiKey { get; set; }

        private String cpgKey { get; set; }

        private String type { get; set; }

        private String descriptor { get; set; }

        private String secretKey { get; set; }

        private String comType { get; set; }
    }
}