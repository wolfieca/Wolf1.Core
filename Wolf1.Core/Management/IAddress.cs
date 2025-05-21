using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Wolf1.Core.Model;

namespace Wolf1.Core.Management
{
    public interface IAddress
    {
        Name Addressee { get; }
        String StreetNumber {get; }
        String StreetDirectional {get; }
        String StreetName {get; }
        String StreetType {get; }
        String AptSuiteNumber {get; }
        String StreetAddress1 { get; }
        String StreetAddress2 {get; }
        String POBox { get; }
        Name Attention { get; }
        String City { get; }
        IState State { get; }
        IZipCode Zip { get; }
        Boolean MailReturned { get; }
    }
}
