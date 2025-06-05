namespace Task8_2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                var account1 = new BankAccount();
                var account2 = new BankAccount();

                account1.Deposit(1000m);
                Console.WriteLine($"Баланс аккаунта №{account1.AccountNumber}: {account1.Balance}");

                account1.Withdraw(1500m);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            BankAccount.ShowTotalAccounts();
        }
    }


    public class BankAccount
    {
        private decimal _balance;

        private static int _totalAccounts = 0;

        public string AccountNumber { get; }

        public decimal Balance => _balance;

        private Random random = new Random();

        public BankAccount()
        {

            AccountNumber = random.Next(1000, 10000).ToString();

            _totalAccounts++;
        }


        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной.");
            }
        }


        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной.");
            }
            if (_balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Недостаточно средств на счету.");
            }
        }


        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Всего создано аккаунтов: {_totalAccounts}");
        }
    }

}
