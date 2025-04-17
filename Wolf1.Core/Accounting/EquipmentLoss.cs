using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.Management;
using Wolf1.Core.Messages;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// This is a message that is sent to equipment that are damaged,
    /// destroyed or otherwise lost. This goes into the 
    /// ServiceHistory for the asset.
    /// </summary>
    class EquipmentLoss : IMessage
    {
        public IPerson ResponsibleParty { get; protected set; }
        public decimal RepairCost { get; set; }
        public decimal OtherCosts { get; set; }
        public decimal WriteOffAmount { get;  protected set; }
        public String Description { get; protected set; }
        public List<IDocument> LossDocuments { get; protected set; }
    }
}
