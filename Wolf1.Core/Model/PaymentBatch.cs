using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Model
{
    class PaymentBatch : IPaymentBatch
    {
        private int _BatchDate;
        private int _BatchMonth;
        private IOffice _BatchOffice;
        private int _BatchNumber;
        private IBatchType _BatchType;
        private List<IPayment> _Payments;
        private Decimal _AssertedBatchTotal;
        private int _AssertedBatchSize;
        private Boolean _Balanced;
        private Boolean _Held;
        private Boolean _Corrupt;
        private Boolean _Done;
        private Boolean _Batch;
        private Boolean _Acknowledge;
        private Boolean _Delete;
        private Boolean _FromConversion;

        public int BatchMonth => _BatchMonth;
        public IOffice BatchOffice => _BatchOffice;
        public int BatchNumber => _BatchNumber;
        public string BatchID => $"{BatchMonth:D2}-{BatchOffice:D3}-{BatchNumber:D4}";
        public IBatchType BatchType => _BatchType;
        public int BatchTransactionsEntered => Payments.Count();
        public decimal BatchDollars
        {
            get
            {
                Decimal total = 0;
                foreach (IPayment Payment in Payments)
                {
                    total += Payment.PaymentAmount;
                }
                return total;
            }
        }
        public List<IPayment> Payments { get => _Payments; protected set => _Payments = value; }
        public int NumberOfPayments => _Payments.Count;
        public bool Balanced { get => _Balanced; protected set => _Balanced = value; }
        public bool Held { get => _Held; protected set => _Balanced = value; }
        public bool Corrupt { get => _Corrupt; protected set => _Corrupt = value; }
        public bool Done { get => _Done; protected set => _Done = value; }
        public bool Batch { get => _Batch; protected set => _Batch = value; }
        public bool Acknowledge { get => _Acknowledge; protected set => _Acknowledge = value; }
        public bool Delete { get => _Delete; protected set => _Delete = value; }
        public bool FromConversion { get => _FromConversion; protected set => _FromConversion = value; }
        public int BatchDate { get => _BatchDate; set => _BatchDate = value; }
        public decimal AssertedBatchDollars { get => _AssertedBatchTotal; protected set => _AssertedBatchTotal = value; } 
        public int AssertedNumberOfPayments { get => _AssertedBatchSize; protected set => _AssertedBatchSize = value; }

        DateTime IPaymentBatch.BatchDate => throw new NotImplementedException();

        public Decimal TotalBreakdown(String Subpart)
        {
            Decimal total = 0;
            foreach(IPayment Payment in Payments)
            {
                total += Payment.BreakDown[Subpart];
            }
            return total;
        }
    }
}
