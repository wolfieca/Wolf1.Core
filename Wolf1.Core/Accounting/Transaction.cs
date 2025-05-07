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

        public Transaction withACL (AccessControlList ACL)
        {
            this.ACL = ACL;
            return this;
        }
        public Transaction withTransactionID ( string TransactionID)
        {
            this.TransactionID = TransactionID;
            return this;
        }
        public Transaction withOriginator ( User Originator)
        {
            this.Originator = Originator;
            return this;
        }
        public Transaction withApprovedBy ( User ApprovedBy )
        {
            this.ApprovedBy = ApprovedBy;
            return this;
        }
        public Transaction forAccount ( GLAccount Account )
        {
            this.Account = Account;
            return this;
        }
        public Transaction forTransactionDate ( DateTime TransactionDate ) 
        {
            this.TransactionDate = TransactionDate;
            return this;
        }
        public Transaction forPromiseDate( DateTime PromiseDate)
        {
            this.PromiseDate = PromiseDate;
            return this;
        }
        public Transaction forApprovalDate ( DateTime ApprovalDate)
        {
            this.ApprovalDate = ApprovalDate;
            return this;
        }
        public Transaction withPostDate ( DateTime PostDate )
        {
            this.PostDate = PostDate;
            return ths;
        }
        public Transaction withCredits ( decimal Credits )
        {
            this.Credits = Credits;
            return this;
        }
        public Transaction withDebits ( decimal Debits )
        {
            this.Debits = Debits;
            return this;
        }
        public Transaction forReference ( Transaction Reference )
        {
            this.Reference = Reference;
            return this;
        }
        public Transaction withMemo ( string Memo )
        {
            this.Memo = Memo;
            return this;
        }
    }
}
