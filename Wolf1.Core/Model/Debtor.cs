using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.Legal;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;

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
        private Boolean _AccrueInterest;
        private Boolean _MergeAllowed;
        private Boolean _SplitAllowed;
        private IPerson _DebtorInfo;
        private Dictionary<String, IDocument> _EmployeeDocuments;
        private IMessageQueue _MessageQueue;


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
       
        public bool Locked { get => _Locked; protected set => _Locked = value; }
        public bool MergeAllowed { get => _MergeAllowed; protected set => _MergeAllowed = value; }
        public bool SplitAllowed { get => _SplitAllowed; protected set => _SplitAllowed = value; }
        public IPerson DebtorInfo { get => _DebtorInfo; protected set => _DebtorInfo=value; }

        public bool MailReturn { get => _MailReturn; protected set => _MailReturn = value; }

        public Dictionary<string, IDocument> EmployeeDocuments => _EmployeeDocuments;

        public IMessageQueue MessageQueue => _MessageQueue;

        public bool AccrueInterest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        /// and Supplemental data are tested and merged with this debtor's
        /// data, as are legal data. 
        /// Legal Actions are considered atomic for purposes of merges and 
        /// splits, so any attempts to merge or split that would result
        /// in a legal action being broken up will fail.</param>
        /// <returns></returns>
        public IDebtor Merge(IDebtor DebtorToMerge)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merge specific debts from the specified debtor to this debtor.
        /// This operators like the above Merge, with the exception that
        /// the specific debts to merge from the secondary account are 
        /// specified and are the only debts that will be affected.
        /// </summary>
        /// <param name="DebtorToMerge"></param>
        /// <param name="DebtsToMerge"></param>
        /// <returns></returns>
        public IDebtor Merge(IDebtor DebtorToMerge, List<IDebt> DebtsToMerge)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merge specific listed debts to this debtor. Operates like the 
        /// above versions, except debts can come from different debtors.
        /// </summary>
        /// <param name="DebtsToMerge"></param>
        /// <returns></returns>
        public IDebtor Merge(List<IDebt> DebtsToMerge)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reassign this debtor to a new Collector. This cleans up reminders 
        /// and such that are currently waiting on the debtor. The exact clean
        /// up process primarily consists of removing items currently waiting
        /// for the old collector, and then sending an initial message to the
        /// new collector's queue to be scheduled and handled as appropriate.
        /// </summary>
        /// <param name="NewCollector">The new Collector to assign this
        /// Debtor to</param>
        /// <returns></returns>
        public ICollector Reassign(ICollector NewCollector)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reasign this debtor to a new Collector. The new Collector is not
        /// directtly specified, but will be of the specified Collector type/
        /// speciality. Otherwise, this works as the above version.
        /// </summary>
        /// <param name="CollectorType"></param>
        /// <returns></returns>
        public ICollector Reassign(string CollectorType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits the listed debts from this Debtor, creating a new Debtor with 
        /// the same debtor information. Debt specific History items, payments,
        /// etc. are also moved along with the debts. Legal Actions can still not
        /// be broken up by a Split operation. The status on the new Debtor is 
        /// left the same as the status on this Debtor.
        /// </summary>
        /// <param name="DebtsToSplit"></param>
        /// <returns></returns>
        public IDebtor Split(List<IDebt> DebtsToSplit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits the listed debts from this Debtor, creating a new Debtor with the 
        /// specified Status
        /// </summary>
        /// <param name="DebtsToSplit"></param>
        /// <param name="NewStatus"></param>
        /// <returns></returns>
        public IDebtor Split(List<IDebt> DebtsToSplit, IStatus NewStatus)
        {
            throw new NotImplementedException();
        }
    }
}
