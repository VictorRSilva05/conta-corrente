
namespace ContaCorrente.WinFormsApp
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }
        private List<string> Transactions = new List<string>();
        public Account()
        {

        }

        public Account(string name, string accountNumber, decimal balance, decimal limit)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
            Limit = limit;
        }

        public string Withdrawl(decimal value)
        {
            if (value < Limit)
            {
                Balance -= value;
                Transactions.Add("Debit R$-" + value.ToString("F2"));
                return "R$" + value.ToString("F2") + " has been removed from your account";
            }
            else
            {
                return "Above limit!";
            }
        }

        public string Deposit(decimal value)
        {
            Balance += value;

            Transactions.Add("Credit R$+" + value.ToString("F2"));
            return "R$" + value.ToString("F2") + " has been deposited into your account";
        }

        public string CheckBalance()
        {
            return Name + " balance's R$" + Balance.ToString("F2");
        }

        public string BankStatement()
        {
            if (Transactions.Count == 0)
            {
                return "No transactions available.";
            }

            return string.Join(Environment.NewLine, Transactions);
        }
    }
}
