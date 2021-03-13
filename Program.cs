using System;

namespace SF.Module25
{
    class Program
    {
        static void Main()
        {
            Account commonAccount = new CommonAccount();
            commonAccount.Balance = 1500;

            Calculator.CalculateInterest(commonAccount);
            PrintAccountInterest(commonAccount);

            Account salaryAccount = new SalaryAccount();
            salaryAccount.Balance = 7000;

            Calculator.CalculateInterest(salaryAccount);
            PrintAccountInterest(salaryAccount);

            Console.ReadKey();
        }

        static void PrintAccountInterest(Account account)
        {
            Console.WriteLine($"Для счета \"{account.Type}\" (баланс {account.Balance}) процентная ставка равна {account.Interest}");
        }
    }
}
