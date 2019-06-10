using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    class BatchType : IBatchType
    {
        private String _Type;
        private Boolean _Payment;
        private Boolean _Adjustment;
        private Boolean _Us;
        private Boolean _Client;
        private Boolean _Reversal;
        private Boolean _Match;

        public string Type { get => _Type; set => _Type = value; }
        public bool Payment { get => _Payment; set => _Payment = value; }
        public bool Adjustment { get => _Adjustment; set => _Adjustment = value; }
        public bool Us { get => _Us; set => _Us = value; }
        public bool Client { get => _Client; set => _Client = value; }
        public bool Reversal { get => _Reversal; set => _Reversal = value; }
        public bool Match { get => _Match; set => _Match = value; }
    }
}
