using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    /// <summary>
    /// IAsset objects are assets belonging to the Company. This would typically
    /// include things like property, vehicles, and equipment
    /// </summary>
    interface IAsset
    {
        String AssetTag { get; set; }
        String Description { get; set; }
        decimal PurchasePrice { get; set; }
        DateTime PurchaseDate { get; set; }
        int PaymentsRemaining { get; set; }
        int PaymentAmount { get; set; }
        IHistory ServiceHistory { get; set; }
        decimal Depreciation{get; set;}
    }
}
