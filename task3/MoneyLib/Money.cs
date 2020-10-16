using System;

namespace MoneyLib
{
    public class Money
    {
        public decimal Amount { get; }
        Currencies Currency { get; }

        public Money(decimal Amount, Currencies currency)
        {

            this.Amount = Amount;
            this.Currency = currency;
        }

        private static decimal ConvertCoefficient(Currencies cur)
        {
            switch (cur)
            {
                case Currencies.BYN: return 1;
                case Currencies.USD: return 2;
                case Currencies.EUR: return 2.5m;
                default: throw new Exception();
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            var resultAmount = m1.Amount + m2.Amount * ConvertCoefficient(m2.Currency) / ConvertCoefficient(m1.Currency);
            return new Money(resultAmount, m1.Currency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            var resultAmount = m1.Amount - m2.Amount * ConvertCoefficient(m2.Currency) / ConvertCoefficient(m1.Currency);
            return new Money(resultAmount, m1.Currency);
        }

        public static Money operator ++(Money m)
        {
            switch (m.Currency)
            {
                case Currencies.BYN:
                    return new Money(m.Amount * 1.3m, m.Currency);
                case Currencies.USD:
                    return new Money(m.Amount * 1.1m, m.Currency);
                case Currencies.EUR:
                    return new Money(m.Amount * 1.2m, m.Currency);
                default: throw new Exception();
            }
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Amount * ConvertCoefficient(m1.Currency) == m2.Amount * ConvertCoefficient(m2.Currency);
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return m1.Amount * ConvertCoefficient(m1.Currency) != m2.Amount * ConvertCoefficient(m2.Currency);
        }

        public static explicit operator string(Money m)
        {
            return $"{m.Amount:f5}_{m.Currency}";
        }

        public static implicit operator int(Money m)
        {
            return (int)Math.Round(m.Amount * ConvertCoefficient(m.Currency));
        }

        public override bool Equals(object obj)
        {
            if (obj is Money m)
            {
                return Amount == m.Amount && Currency == m.Currency;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() + (int)Currency;
        }
    }
}
