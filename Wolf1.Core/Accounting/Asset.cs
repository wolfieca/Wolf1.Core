using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    public class Asset : IAsset
    {

        public string AssetTag { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set;}
        public DateTime PurchaseDate { get; set;}
        public int PaymentsRemaining { get; set;}
        public int PaymentAmount { get; set;}
        public IHistory ServiceHistory { get; set;}
        public decimal Depreciation { get; set;}
    }
}
