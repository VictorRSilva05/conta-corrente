using System.Runtime.CompilerServices;
using System.Security.Principal;

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
            var account = FindAccount();
            if (account == null)
            {
                return;
            }

            MessageBox.Show(account.CheckBalance());

            ClearMovimentationTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var account = FindAccount();
            if (account == null)
            {
                return;
            }

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
            var account = FindAccount();
            if (account == null)
            {
                return;
            }

            decimal value = Convert.ToDecimal(textBoxValueMovimentation.Text);

            MessageBox.Show(account.Withdrawl(value));

            ClearMovimentationTextBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var transferingAccount = FindAccount();
            if (transferingAccount == null)
            {
                return;
            }
            var receivingAccount = accounts.Find(a => a.AccountNumber == textBoxTransferMovimentation.Text);

            decimal value = Convert.ToDecimal(textBoxValueMovimentation.Text);

            transferingAccount.Withdrawl(value);
            receivingAccount.Deposit(value);

            MessageBox.Show("Transference complete");

            ClearMovimentationTextBoxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var account = FindAccount();
            if (account == null)
            {
                return;
            }

            MessageBox.Show(account.BankStatement());
        }

        private Account FindAccount()
        {
            try
            {
                var account = accounts.Find(a => a.AccountNumber == textBoxAccountNumberMovimentation.Text);
                if (account == null)
                {
                    throw new Exception("Account not found");
                }
                return account;
            }
            catch (Exception)
            {
                MessageBox.Show("Account not found");
                return null;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyLettersToTextBox(e);
        }

        private static void AllowOnlyLettersToTextBox(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);
        }

        private void textBoxInitialBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;

        }

        private void textBoxLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;
        }

        private void textBoxAccountNumberMovimentation_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);
        }

        private void textBoxTransferMovimentation_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);
        }

        private void textBoxValueMovimentation_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersToTextBox(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') ;
        }

        private static void AllowOnlyNumbersToTextBox(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
