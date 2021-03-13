namespace SF.Module25
{
    public interface ICalculateInterest
    {
        void CalculateInterest();
    }

    public abstract class Account : ICalculateInterest
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public abstract void CalculateInterest();
    }

    public class CommonAccount : Account
    {
        public CommonAccount()
        {
            Type = "Обычный";
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }

    public class SalaryAccount : Account
    {
        public SalaryAccount()
        {
            Type = "Зарплатный";
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
