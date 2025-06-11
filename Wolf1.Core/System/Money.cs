using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Wolf1.Core.System
{
    public class Money
    {
        public Money(decimal amount, string prefix, string name)
        {
            Amount = amount;
            Prefix = prefix;
            Name = name;
        }
        public Money(decimal amount)
        {
            Amount = amount;
            Prefix = "$";
            Name = "USD";
        }
        public Money()
        {
            Amount = 0.0m;
            Prefix = "$";
            Name = "USD";
        }

        public decimal Amount { get; }
        public string Prefix { get; }
        public string Name { get; }
        public static bool Compatible(Money a, Money b)
        {
            return a.Name.Equals(b.Name) && a.Prefix.Equals(b.Prefix);
        }
        public static Money operator +(Money first, Money second)
        {
            if (Compatible(first, second))
                return new Money(first.Amount + second.Amount, first.Prefix, first.Name);
            throw new IncompatibleCurrenciesException();
        }
        public static Money operator -(Money first, Money second)
        {
            if (Compatible(first, second))
                return new Money(first.Amount - second.Amount, first.Prefix, first.Name);
            throw new IncompatibleCurrenciesException();
        }
        public static Money operator *(Money amount, double multiplicand)
        {
            return new Money(amount.Amount * (decimal)multiplicand);
        }
    }
    public class IncompatibleCurrenciesException : Exception {
        
    }
}
