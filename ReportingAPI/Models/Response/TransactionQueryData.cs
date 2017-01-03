using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingAPI.Models.Response
{
    public class TransactionQueryData
    {
        private Fx fx;

        private CustomerInfo customerInfo;

        private AcquirerTransactions acquirerTransactions;

        private Merchant merchant;

        private MerchantTransactions merchantTransactions;
    }
}