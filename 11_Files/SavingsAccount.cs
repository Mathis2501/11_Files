namespace _11_Files
{
    class SavingsAccount : IAsset
    {
        public string AccountName;
        public double Value;
        public double InterestRate;

        public SavingsAccount(string secondaryAccountName, double secondaryValue, double secondaryInterestRate)
        {
            AccountName = secondaryAccountName;
            Value = secondaryValue;
            InterestRate = secondaryInterestRate;
        }

        public override string ToString()
        {
            return "SavingsAccount[value=" + Value.ToString("##.0").Replace(",", ".") + ",interestRate=" + InterestRate.ToString().Replace(",", ".") + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        public void ApplyInterest()
        {
            Value *= (InterestRate / 100) + 1;
        }

        public string GetName()
        {
            return AccountName;
        }

    }
}
