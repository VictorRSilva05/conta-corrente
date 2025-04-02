
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

        public void Withdrawl()
        {

        }

        public void Deposit()
        {

        }

    }
}
