using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    class State : IState
    {
        public string StateName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StatePostAbbrev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MailRestricted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IZipCode MinZipCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IZipCode MaxZipCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ZipInState(IZipCode ZipCode)
        {
            throw new NotImplementedException();
        }
    }
}
