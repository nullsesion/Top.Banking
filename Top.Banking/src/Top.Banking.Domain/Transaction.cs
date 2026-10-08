using System;
using System.Collections.Generic;
using System.Text;
using Top.Banking.Domain.Enums;
using static System.Net.WebRequestMethods;

namespace Top.Banking.Domain
{
    public class Transaction
    {
        public Guid TransactionID { get; set; }
        public Guid SourceAccountID { get; set; }
        public Guid DestinationAccountID { get; set; }
        public Decimal Amount { get; set; }
        
        public TypeTransaction Type { get; set; }
        public bool IsSuccess { get; set; }
    }
}
