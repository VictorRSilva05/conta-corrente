
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

        public void Withdrawl(decimal value)
        {
            if (value < Limit)
                Balance -= value;
            else
                MessageBox.Show("Above limit!");
        }

        public string Deposit(decimal value)
        {
            Balance += value;

            return "R$" + value.ToString("F2") + " has been deposited into your account";
        }

        public string CheckBalance()
        {
            return  Name + " balance's R$" + Balance.ToString("F2");
        }

    }
}
