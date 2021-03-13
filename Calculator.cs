namespace SF.Module25
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculateInterest account)
        {
            account.CalculateInterest();
        }
    }
}
