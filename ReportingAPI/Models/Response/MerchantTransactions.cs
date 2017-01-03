using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class MerchantTransactions
    {
        public String referenceNo { get; set; }

        public int merchantNo { get; set; }

        public String status { get; set; }

        public String channel { get; set; }

        public String customDate { get; set; }

        public String chainId { get; set; }

        public int agentInfoId { get; set; }

        public String operation { get; set; }

        public int fxTransactionId { get; set; }

        [JsonProperty("updated_at")]
        public String updatedAt { get; set; }

        [JsonProperty("created_at")]
        public String createdAt { get; set; }

        public int Id { get; set; }

        public int acquirerTransactionId { get; set; }

        public String code { get; set; }

        public String message { get; set; }

        public String transactionId { get; set; }

        //Agent agent;
    }
}