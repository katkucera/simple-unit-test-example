using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public void Debit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount; // intentional error
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount;
        }

        static void Main(string[] args)
        {
            var ba = new BankAccount("Kate Bush", 180.00);

            ba.Credit(20.00);
            ba.Debit(50.00);
            Console.WriteLine($"Current balance is {ba.Balance} ");
        }
    }
}
