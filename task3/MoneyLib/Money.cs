using System;

namespace MoneyLib
{
    public class Money
    {
        public decimal Amount { get; }
        decimal AmountGeneral;
        Currencies currency;

        public Money(decimal Amount, Currencies currency)
        {

            this.Amount = Amount;
            this.AmountGeneral = Amount * ConvertCoefficent(currency);
            this.currency = currency;
        }

        static decimal ConvertCoefficent(Currencies cur)
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
            if (m1.currency == m2.currency)
                return new Money(m1.Amount + m2.Amount, m1.currency);
            else
                return new Money((m1.AmountGeneral + m2.AmountGeneral) / ConvertCoefficent(m1.currency), m1.currency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            if (m1.currency == m2.currency)
                return new Money(m1.Amount - m2.Amount, m1.currency);
            else
                return new Money((m1.AmountGeneral - m2.AmountGeneral) / ConvertCoefficent(m1.currency), m1.currency);
        }

        public static Money operator ++(Money m)
        {
            switch (m.currency)
            {
                case Currencies.BYN:
                    return new Money(m.Amount * 1.3m, m.currency);
                case Currencies.USD:
                    return new Money(m.Amount * 1.1m, m.currency);
                case Currencies.EUR:
                    return new Money(m.Amount * 1.2m, m.currency);
                default: throw new Exception();
            }
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.AmountGeneral == m2.AmountGeneral;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return m1.AmountGeneral != m2.AmountGeneral;
        }

        public static explicit operator string(Money m)
        {
            return new string($"{m.Amount:f5}_{m.currency}");
        }

        public static implicit operator int(Money m)
        {
            return (int)Math.Round(m.AmountGeneral);
        }

        public override bool Equals(object obj)
        {
            Money m = obj as Money;
            if (obj as Money == null)
            {
                return false;
            }

            return Amount == m.Amount && currency == m.currency;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() + (int)currency;
        }
    }
}
