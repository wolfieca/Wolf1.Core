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

        public int DebtorNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal CurrentBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal OriginalBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDemographics Demographics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IHistory History { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IClient PrimaryClient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPayment Payments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ILegalAction LegalActions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollector Collector { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public IDebtor Split(List<IDebt> DebtsToSplit)
        {
            throw new NotImplementedException();
        }
    }
}
