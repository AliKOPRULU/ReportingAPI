using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class CustomerInfo
    {
        public int id​ { get; set; }

        [DataType(DataType.DateTime),DisplayFormat(DataFormatString ="{0:yyyy-MM-dd hh-mm-ss}")]
        public DateTime createdAt { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh-mm-ss}")]
        public DateTime updatedAt { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh-mm-ss}")]
        public DateTime deletedAt { get; set; }

        private String number { get; set; }

        private String expiryMonth { get; set; }

        private String expiryYear { get; set; }

        private String startMonth { get; set; }

        private String startYear { get; set; }

        private String issueNumber { get; set; }

        private String email { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh-mm-ss}")]
        private String birthday { get; set; }

        private String gender { get; set; }

        private String billingTitle { get; set; }

        private String billingFirstName { get; set; }

        private String billingLastName { get; set; }

        private String billingCompany { get; set; }

        private String billingAddress1 { get; set; }

        private String billingAddress2 { get; set; }

        private String billingCity { get; set; }

        private String billingPostCode { get; set; }

        private String billingState { get; set; }

        private String billingCountry { get; set; }

        private String billingPhone { get; set; }

        private String billingFax { get; set; }

        private String shippingTitle { get; set; }

        private String shippingFirstName { get; set; }

        private String shippingLastName { get; set; }

        private String shippingCompany { get; set; }

        private String shippingAddress1 { get; set; }

        private String shippingAddress2 { get; set; }

        private String shippingCity { get; set; }

        private String shippingPostCode { get; set; }

        private String shippingState { get; set; }

        private String shippingCountry { get; set; }

        private String shippingPhone { get; set; }

        private String shippingFax { get; set; }

    }
}