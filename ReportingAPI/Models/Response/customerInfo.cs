using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class CustomerInfo
    {
        public int id​ { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public DateTime deletedAt { get; set; }

        private String number;

        private String expiryMonth;

        private String expiryYear;

        private String startMonth;

        private String startYear;

        private String issueNumber;

        private String email;

        private String birthday;

        private String gender;

        private String billingTitle;

        private String billingFirstName;

        private String billingLastName;

        private String billingCompany;

        private String billingAddress1;

        private String billingAddress2;

        private String billingCity;

        private String billingPostCode;

        private String billingState;

        private String billingCountry;

        private String billingPhone;

        private String billingFax;

        private String shippingTitle;

        private String shippingFirstName;

        private String shippingLastName;

        private String shippingCompany;

        private String shippingAddress1;

        private String shippingAddress2;

        private String shippingCity;

        private String shippingPostCode;

        private String shippingState;

        private String shippingCountry;

        private String shippingPhone;

        private String shippingFax;

    }
}