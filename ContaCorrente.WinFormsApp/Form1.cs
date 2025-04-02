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

            textBoxName.Clear();
            textBoxNumber.Clear();
            textBoxInitialBalance.Clear();
            textBoxLimit.Clear();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxNumber.Clear();
            textBoxInitialBalance.Clear();
            textBoxLimit.Clear();
        }
    }
}
