using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Messages;
using Wolf1.Core.Model;

namespace Wolf1.Core.Management
{
    public class BankruptcyInformation {
        public Bankruptcy BankruptcyChapter{get; private set;} = Bankruptcy.NO;
        public BankruptcyClaimStatus CurrentStatus {get; private set;} = BankruptcyClaimStatus.NONE;
        public string CaseNumber {get; private set;}
        public Account[] IncludedAccounts { get; private set;}
        
    }
}
