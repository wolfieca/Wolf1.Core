using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    class Asset : IAsset
    {
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
