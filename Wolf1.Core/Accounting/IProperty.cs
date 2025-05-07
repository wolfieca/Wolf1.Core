using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    /// <summary>
    /// Goods such as land and building that belong to or are rented by the 
    /// company.
    /// </summary>
    public interface IProperty : IAsset
    {
        IAddress Location { get; set; }
        IPerson Owner { get; set; }
        Boolean Rental { get; set; }
        int Owed { get; set; }
        DateTime MortgageStart { get; set; }
        DateTime MortgageEnd { get; set; }

    }
}
