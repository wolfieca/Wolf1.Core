using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.Model;

namespace Wolf1.Core.Messages
{
    public enum BankruptcyClaimStatus { NONE, FILED, ADJUDICATED, DISCHARGED, DISMISSED};
    class BankruptcyClaim : MessageBody
    {
        public DateTime DateFiled;
        public List<Account> AccountsIncludedInBankruptcy;
        public Bankruptcy BankruptcyType = Bankruptcy.NO;
        public BankruptcyClaimStatus ClaimStatus = BankruptcyClaimStatus.NONE;
    }
}
