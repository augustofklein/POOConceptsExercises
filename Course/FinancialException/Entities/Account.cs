using FinancialException.Entities.Exceptions;

namespace FinancialException.Entities
{
	public class Account
	{
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enought balance");
            }

            Balance -= amount;
        }

        public void Deposit(double amout)
        {
            Balance += amout;
        }
    }
}

