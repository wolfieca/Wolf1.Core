using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Formatters;
using Wolf1.Core.Management;
using Wolf1.Core.Model;
using Wolf1.Core.System;


namespace Wolf1.Core.Legal
{
    public enum CourtClass
    {
        County = 0b0000,
        City = 0b0001,
        District = 0b0010,
        Region = 0b0011
    }

    public record Court
    {
        public string Name { get; }
        public string County { get; }
        public CourtClass Class { get; }
        public Address Address { get; }
        public PhoneNumber ClerkPhone { get; }
        public string CourtExtra { get; }
        public string Comment { get; }
    }

    /// <summary>
    /// LegalStatuses that can apply to a suit
    ///     SUIT    Suit has been filed
    ///     DISM    Suit has been dismissed
    ///     JUDG    Judgment has been entered
    ///     EXEC    Judgment is being executed
    ///     SATI    Judgment has been satisfied
    ///     BKCL    Bankruptcy
    ///     PRES    
    ///     RNEW    Judgment to be renewed
    /// </summary>
    public enum LegalStatus
    {
        DISM, JUDG, EXEC, SUIT, SATI, BKCL, PRES, RNEW
    }


    public record LegalAction : ILegalAction
    {
        public LegalAction()
        {
            LegalStatus = LegalStatus.SUIT;
            SuitDate = DateTime.Now;
        }
        public LegalStatus LegalStatus { get; private set; }
        public Account PrimaryAccount { get; private set; } = null;
        public List<Account> IncludedDebts { get; private set; }
        public DateTime SuitDate { get; private set; }
        public Money SuitAmount { get; private set; }
        public Attorney Attorney { get; private set; }
        public Court Court { get; private set; }
        public Dictionary<string, ILegal> LegalData { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateTo"></param>
        /// <returns></returns>
        public LegalAction UpdateLegalStatus(LegalStatus updateTo)
        {
            this.LegalStatus = updateTo;
            return this;
        }

        /// <summary>
        /// Add a single account to the LegalAction
        /// </summary>
        /// <param name="accountToAdd"></param>
        /// <returns></returns>
        public LegalAction AddAccount(Account accountToAdd)
        {
            if (PrimaryAccount is not null)
                IncludedDebts.Add(accountToAdd);
            else
                PrimaryAccount = accountToAdd;

            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountListToAdd"></param>
        /// <returns></returns>
        public LegalAction AddAccount(List<Account> accountListToAdd)
        {
            IncludedDebts.AddRange(accountListToAdd);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPrimaryAccount"></param>
        /// <returns></returns>
        public LegalAction SetPrimaryAccount(Account newPrimaryAccount)
        {
            if (PrimaryAccount is not null)
            {
                if (IncludedDebts.Contains(newPrimaryAccount))
                {
                    IncludedDebts.Add(PrimaryAccount);
                    PrimaryAccount = newPrimaryAccount;
                    IncludedDebts.Remove(newPrimaryAccount);
                }
                return this;
            }
            else
            {
                PrimaryAccount = newPrimaryAccount;
                return this;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newDate"></param>
        /// <returns></returns>
        public LegalAction SetSuitDate(DateTime newDate)
        {
            SuitDate = newDate;
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LegalAction CalculateSuitAmount()
        {
            SuitAmount = PrimaryAccount.TotalOwed[MoneyTypes.Principal] + PrimaryAccount.TotalOwed[MoneyTypes.CollectionCharge] +
            PrimaryAccount.TotalOwed[MoneyTypes.Interest] + PrimaryAccount.TotalOwed[MoneyTypes.CourtCosts] +
            PrimaryAccount.TotalOwed[MoneyTypes.AttorneyFees] + PrimaryAccount.TotalOwed[MoneyTypes.LegalFees];
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="assignedAttorney"></param>
        /// <returns></returns>
        public LegalAction AssignToAttorney(Attorney assignedAttorney)
        {
            Attorney = assignedAttorney;
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="assignedCourt"></param>
        /// <returns></returns>
        public LegalAction SuitAssignedToCourt(Court assignedCourt)
        {
            Court = assignedCourt;
            return this;
        }
    }
}
