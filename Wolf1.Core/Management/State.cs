using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// State represents States as found in the United States.
    /// </summary>
    class State : IState
    {
        private String _StateName;
        private String _StatePostAbbreviation;
        private Boolean _MailRestricted;
        private Zip _MinZipCode;
        private Zip _MaxZipCode;

        public string StateName { get => _StateName; set => _StateName = value; } 
        public string StatePostAbbrev { get => _StatePostAbbreviation; set => _StatePostAbbreviation = value; }
        public bool MailRestricted { get => _MailRestricted; set => _MailRestricted = value; }
        public Zip MinZipCode { get => _MinZipCode; set => _MinZipCode = value; }
        public Zip MaxZipCode { get => _MaxZipCode; set => _MaxZipCode = value; }

        public bool ZipInState(Zip ZipCode)
        {
            return (MaxZipCode >= ZipCode) && (ZipCode >= MinZipCode);
        }

    }
}
