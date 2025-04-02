
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

        public Account(string accountNumber, string name, decimal balance, decimal limit)
        {
            AccountNumber = accountNumber;
            Name = name;
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

        public void Deposit(decimal value)
        {
            Balance += value;
        }

        public string CheckBalance()
        {
            return  Name + " balance's R$" + Balance.ToString("F2");
        }

    }
}
