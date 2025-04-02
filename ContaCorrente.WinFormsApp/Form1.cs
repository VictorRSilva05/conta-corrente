using System.Runtime.CompilerServices;

namespace ContaCorrente.WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterAccount(string name, string number, decimal initialBalance, decimal limit)
        {
            accounts.Add(new Account(name, number, initialBalance, limit));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string number = textBoxNumber.Text;
            decimal initialBalance = decimal.Parse(textBoxInitialBalance.Text);
            decimal limit = decimal.Parse(textBoxLimit.Text);

            RegisterAccount(name, number, initialBalance, limit);

            MessageBox.Show("Account registred!");

            ClearRegistrationTextBoxes();
        }

        private void ClearRegistrationTextBoxes()
        {
            textBoxName.Clear();
            textBoxNumber.Clear();
            textBoxInitialBalance.Clear();
            textBoxLimit.Clear();
        }

        private void ClearMovimentationTextBoxes()
        {
            textBoxAccountNumberMovimentation.Clear();
            textBoxValueMovimentation.Clear();
            textBoxTransferMovimentation.Clear();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearRegistrationTextBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var account = accounts.Find(a => a.AccountNumber == textBoxAccountNumberMovimentation.Text);

            MessageBox.Show(account.CheckBalance());

            ClearMovimentationTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var account = accounts.Find(a => a.AccountNumber == textBoxAccountNumberMovimentation.Text);

            decimal value = Convert.ToDecimal(textBoxValueMovimentation.Text);

            MessageBox.Show(account.Deposit(value));

            ClearMovimentationTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearMovimentationTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var account = accounts.Find(a => a.AccountNumber == textBoxAccountNumberMovimentation.Text);

            decimal value = Convert.ToDecimal(textBoxValueMovimentation.Text);

            MessageBox.Show(account.Withdrawl(value));

            ClearMovimentationTextBoxes();
        }
    }
}
