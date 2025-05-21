using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Model;

namespace Wolf1.Core.Management
{
    public class Address : IAddress
    {
        public Name Addressee { get => throw new NotImplementedException(); }
        public String POBox { get => throw new NotImplementedException(); }
        public Name Attention { get => throw new NotImplementedException(); }
        public Boolean MailReturned { get => throw new NotImplementedException(); }
        public String StreetNumber { get => throw new NotImplementedException(); }
        public String StreetDirectional { get => throw new NotImplementedException(); }
        public String StreetName { get => throw new NotImplementedException(); }
        public String StreetType { get => throw new NotImplementedException(); }
        public String AptSuiteNumber { get => throw new NotImplementedException(); }
        public String StreetAddress1 { get => throw new NotImplementedException(); }
        public String StreetAddress2 { get => throw new NotImplementedException(); }
        public String City { get => throw new NotImplementedException(); }
        public IState State { get => throw new NotImplementedException(); }
        public IZipCode Zip { get => throw new NotImplementedException(); }

    }
}