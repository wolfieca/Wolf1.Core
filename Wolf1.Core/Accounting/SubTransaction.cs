using System;
using Wolf1.Core;
using Wolf1.Core.Accounting;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    public class SubTransaction 
    {
        public GLAccount Account { get => Account ; private set => Account = value; }
        public Decimal Credit { get => Credit; private set => Credit = value; }
        public Decimal Debit  { get => Debit; private set => Debit = value; }
        public string Memo { get => Memo; private set => Memo = value; }
    }
}