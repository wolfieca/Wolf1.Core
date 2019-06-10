using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Legal;
using Wolf1.Core.Management;

namespace Wolf1.Core.Model
{
    class Debtor : IDebtor
    {
        private int _DebtorNumber;
        private IDemographics _Demographics;
        private IHistory _History;
        private IPaymentHistory _Payments;
        private Dictionary<int, ILegalAction> _LegalActions;
        private ICollector _Collector;
        private ISupplemental _SupplementalData;
        private DateTime _OriginalReceivedDate;
        private Dictionary<int, IDebt> _Debts;
        private Boolean _MailReturn;
        private Boolean _Locked;
        private Boolean _MergeAllowed;
        private Boolean _SplitAllowed;
        private IPerson _DebtorInfo;



        public int DebtorNumber { get => _DebtorNumber; protected set { if (_DebtorNumber == 0) { _DebtorNumber = value; } } }
        public decimal CurrentBalance { get => throw new NotImplementedException(); }
        public decimal OriginalBalance { get => throw new NotImplementedException(); }
        public IDemographics Demographics { get => _Demographics; protected set { _Demographics = value; } }
        public IHistory History { get => _History; protected set { _History = value; } }
        public IClient PrimaryClient { get => throw new NotImplementedException();  }
        public IPaymentHistory Payments { get => _Payments; protected set => _Payments = value; }
        public Dictionary<int,ILegalAction> LegalActions { get => _LegalActions; protected set => _LegalActions = value; }
        public ICollector Collector { get => _Collector; protected set => _Collector = value; }
        public ISupplemental SupplementalData { get => _SupplementalData; protected set => _SupplementalData = value; }
        public DateTime OriginalReceivedDate { get => _OriginalReceivedDate; protected set => _OriginalReceivedDate = value; }
        public Dictionary<int, IDebt> Debts { get => _Debts; protected set => _Debts = value; }
       
        public bool Locked { get => _Locked; protected set => throw new NotImplementedException(); }
        public bool MergeAllowed { get => _MergeAllowed; protected set => _MergeAllowed = value; }
        public bool SplitAllowed { get => _SplitAllowed; protected set => _SplitAllowed = value; }
        public IPerson DebtorInfo { get => _DebtorInfo; protected set => _DebtorInfo=value; }

        public bool MailReturn { get => _MailReturn; protected set => _MailReturn = value; }

        /// <summary>
        /// Apply the specified payment. This registers the payment with the 
        /// Debtor, adding it to the Payment History for the Debtor. This is
        /// accomplished by iterating through the relevant Debts, and calling
        /// those Debts ApplyPayment methods. By implementation, a Payment is
        /// applicable to only a single Debt, which simplifies this. The 
        /// PaymentHistory for the Debtor is a conglomeration of the Debts'
        /// respective PaymentHistor(ies).
        /// </summary>
        /// <param name="Payment">The payment to apply.</param>
        /// <returns>True if the call succeeds.</returns>
        public bool ApplyPayment(IPayment Payment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merge a Debtor to this one.
        /// </summary>
        /// <param name="DebtorToMerge">The debtor to merge. Both Debtors
        /// in a merge must have MergeAllowed set to true. Demographic
        /// and Supplemental data are tested</param>
        /// <returns></returns>
        public IDebtor Merge(IDebtor DebtorToMerge)
        {
            throw new NotImplementedException();
        }

        public IDebtor Merge(IDebtor DebtorToMerge, List<IDebt> DebtsToMerge)
        {
            throw new NotImplementedException();
        }

        public IDebtor Merge(List<IDebt> DebtsToMerge)
        {
            throw new NotImplementedException();
        }

        public ICollector Reassign(ICollector NewCollector)
        {
            throw new NotImplementedException();
        }

        public ICollector Reassign(string CollectorType)
        {
            throw new NotImplementedException();
        }

        public IDebtor Split(List<IDebt> DebtsToSplit)
        {
            throw new NotImplementedException();
        }
    }
}
