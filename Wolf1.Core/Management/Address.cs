using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Model;

namespace Wolf1.Core.Management
{
    public class Address : IAddress
    {
        public Name Addressee { get; }
        public String POBox { get; }
        public Name Attention { get; }
        public Boolean MailReturned { get; }
        public String StreetNumber { get; }
        public String StreetDirectional { get; }
        public String StreetName { get; }
        public String StreetType { get; }
        public String AptSuiteNumber { get; }
        public String StreetAddress1 { get; }
        public String StreetAddress2 { get; }
        public String City { get; }
        public IState State { get; }
        public IZipCode Zip { get; }
        public override string ToString()
        {
            return Addressee.ToString() == "" ? "" : Addressee.ToString() + "\n" +
            Attention.ToString() == "" ? "" : "ATTN: " + Attention.ToString() + "\n" +
            StreetNumber == "" ? "" : StreetNumber + " " + StreetDirectional + " " + StreetName + " " + StreetType + " " + AptSuiteNumber + "\n" +
            POBox == "" ? "" : "PO Box: " + POBox + "\n" +
            StreetAddress1 == "" ? "" : StreetAddress1 + "\n" +
            StreetAddress2 == "" ? "" : StreetAddress2 + "\n" +
            City + ", " + State + " " + Zip + "\n";
        }
    }
}