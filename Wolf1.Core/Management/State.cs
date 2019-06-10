using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    class State : IState
    {
        private String _StateName;
        private String _StatePostAbbreviation;
        private Boolean _MailRestricted;
        private IZipCode _MinZipCode;
        private IZipCode _MaxZipCode;

        public string StateName { get => _StateName; set => _StateName = value; } 
        public string StatePostAbbrev { get => _StatePostAbbreviation; set => _StatePostAbbreviation = value; }
        public bool MailRestricted { get => _MailRestricted; set => _MailRestricted = value; }
        public IZipCode MinZipCode { get => _MinZipCode; set => _MinZipCode = value; }
        public IZipCode MaxZipCode { get => _MaxZipCode; set => _MaxZipCode = value; }

        public bool ZipInState(IZipCode ZipCode)
        {
            return (int.Parse(MaxZipCode.ZipCode) >= int.Parse(ZipCode.ZipCode)) &&
                (int.Parse(MinZipCode.ZipCode) <= int.Parse(ZipCode.ZipCode));
        }
    }
}
