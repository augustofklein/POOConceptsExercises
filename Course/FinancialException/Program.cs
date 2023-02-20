using FinancialException.Entities;
using FinancialException.Entities.Exceptions;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Inicial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, inicialBalance, withDrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.WithDraw(amountWithdraw);

                Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}