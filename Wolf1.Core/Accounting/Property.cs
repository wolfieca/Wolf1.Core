using System;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    public class Property : IProperty
    {
        public IAddress Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPerson Owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Rental { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Owed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime MortgageStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime MortgageEnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AssetTag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal PurchasePrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PurchaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentsRemaining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IHistory ServiceHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Depreciation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}