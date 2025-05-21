using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    /// <summary>
    /// A single transaction
    /// </summary>
    public class Transaction : ISecurable
    {
        public Transaction()
        {
            ACL = new AccessControlList();
            TransactionID = "";
            Originator = new User();
            ApprovedBy = new User();
            Account = new GLAccount();
            TransactionDate = new DateTime();
            Credits = 0.0m;
            Debits = 0.0m;
            Memo = "";
        }
        public AccessControlList ACL { get => ACL; private set => ACL = value; }
        public string TransactionID { get => TransactionID; private set => TransactionID = value; }
        public User Originator { get => Originator; private set => Originator = value; }
        public User ApprovedBy { get => ApprovedBy; private set => ApprovedBy = value; }
        public GLAccount Account { get => Account; private set => Account = value; }
        public DateTime TransactionDate { get => TransactionDate; private set => TransactionDate = value; }
        public DateTime PromiseDate { get => PromiseDate; private set => PromiseDate = value; }
        public DateTime ApprovalDate { get => ApprovalDate; private set => ApprovalDate = value; }
        public DateTime PostDate { get => PostDate; private set => PostDate = value; }
        public Decimal Credits { get => Credits; private set => Credits = value; }
        public Decimal Debits { get => Debits; private set => Debits = value; }
        public Transaction Reference { get => Reference; private set => Reference = value; }
        public string Memo { get => Memo; private set => Memo = value; }

        public Transaction WithACL (AccessControlList ACL)
        {
            this.ACL = ACL;
            return this;
        }
        public Transaction WithTransactionID ( string TransactionID)
        {
            this.TransactionID = TransactionID;
            return this;
        }
        public Transaction WithOriginator ( User Originator)
        {
            this.Originator = Originator;
            return this;
        }
        public Transaction WithApprovedBy ( User ApprovedBy )
        {
            this.ApprovedBy = ApprovedBy;
            return this;
        }
        public Transaction ForAccount ( GLAccount Account )
        {
            this.Account = Account;
            return this;
        }
        public Transaction ForTransactionDate ( DateTime TransactionDate ) 
        {
            this.TransactionDate = TransactionDate;
            return this;
        }
        public Transaction ForPromiseDate( DateTime PromiseDate)
        {
            this.PromiseDate = PromiseDate;
            return this;
        }
        public Transaction ForApprovalDate ( DateTime ApprovalDate)
        {
            this.ApprovalDate = ApprovalDate;
            return this;
        }
        public Transaction WithPostDate ( DateTime PostDate )
        {
            this.PostDate = PostDate;
            return this;
        }
        public Transaction WithCredits ( decimal Credits )
        {
            this.Credits = Credits;
            return this;
        }
        public Transaction WithDebits ( decimal Debits )
        {
            this.Debits = Debits;
            return this;
        }
        public Transaction ForReference ( Transaction Reference )
        {
            this.Reference = Reference;
            return this;
        }
        public Transaction WithMemo ( string Memo )
        {
            this.Memo = Memo;
            return this;
        }
    }
}
