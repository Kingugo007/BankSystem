using BankSystemCore.Interface;
using BankSystemCore.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Dashboard : Form
    {
        public string name { get { return this.txtFullName.Text; } 
            set 
            {
                this.txtFullName.Text = value;
            } 
        
        }
        public string balance
        {
            get { return this.txtBalanceValue.Text.ToString(); }
            set
            {
                this.txtBalanceValue.Text = value;
            }

        }   

        private readonly ITransactionServices _transactionServices;
        private readonly IValidators _validate;
        private readonly IAccountDTO _account;
        private readonly IAccountServices _accountServices;
        private IServiceProvider _serviceProvider;

        public Dashboard(ITransactionServices transactionServices, IValidators validate, IAccountDTO account,IAccountServices accountServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _transactionServices = transactionServices;
            _validate = validate;
            _account = account;
            _accountServices = accountServices;
            _serviceProvider = serviceProvider;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void transf_btn_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            string txtamount = txtTransferAmount.Text;
            string senderAccount = txtTransfer.Text;
            string receiverAccount = txtReciever.Text;

            if (!_validate.CheckNumber(txtamount))
            {
                MessageBox.Show("Enter a valid number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_validate.CheckAccountNumber(receiverAccount))
            {
                MessageBox.Show("Enter a valid account number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                amount = decimal.Parse(txtamount);
                var result = await _transactionServices.transfer(amount, senderAccount, receiverAccount);
                if (!result.Status)
                {
                    MessageBox.Show(result.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount = 0; 
            string txtamount = txtDepositAmount.Text;
            string accountNumber = txtAccountNumber.Text;
            if (!_validate.CheckNumber(txtamount))
            {
                MessageBox.Show("Enter a valid number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_validate.CheckAccountNumber(accountNumber))
            {
                MessageBox.Show("Enter a valid account number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                amount = decimal.Parse(txtamount);
                var result = await _transactionServices.deposit(amount, accountNumber);
                if (!result.Status)
                {
                    MessageBox.Show(result.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }          

        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            string txtamount = txtAmount.Text;
            string accountNumber = txtAccountNumber2.Text;
            if (!_validate.CheckNumber(txtamount))
            {
                MessageBox.Show("Enter a valid number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_validate.CheckAccountNumber(accountNumber))
            {
                MessageBox.Show("Enter a valid account number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                amount = decimal.Parse(txtamount);
                var result = await _transactionServices.withdraw(amount, accountNumber);
                if (!result.Status)
                {
                    MessageBox.Show(result.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            var listOfUserAccount = await _accountServices.getAllAccount(_account.LoggedAccount.UserId);        
            txtAccountNumber.Items.Clear();
            var cc = listOfUserAccount.Select(x => x.AccountNumber).ToArray();
            txtAccountNumber.Items.AddRange(cc);

            txtAccountNumber2.Items.Clear();
            var cc2 = listOfUserAccount.Select(x => x.AccountNumber).ToArray();
            txtAccountNumber2.Items.AddRange(cc2);

            txtAccountNumber3.Items.Clear();
            var cc3 = listOfUserAccount.Select(x => x.AccountNumber).ToArray();
            txtAccountNumber3.Items.AddRange(cc3);

            txtTransfer.Items.Clear();
            var cc4 = listOfUserAccount.Select(x => x.AccountNumber).ToArray();
            txtTransfer.Items.AddRange(cc4);
        }

        private void txtAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewAccount create = _serviceProvider.GetRequiredService<CreateNewAccount>();
            create.Show();
        }

        private void txtLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = _serviceProvider.GetRequiredService<Login>();
            this.Dispose();
            login.Show();
            this.Close();
        }

        private void txtShowBalance_Click(object sender, EventArgs e)
        {

        }

        private async void btnShowBalance_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber3.Text;
           if (!_validate.CheckAccountNumber(accountNumber))
            {
                MessageBox.Show("Enter a valid account number", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {        
                var result = await _transactionServices.checkBalance(accountNumber);
                txtShowBalance.Text = result.Balance.ToString();    
            }

        }

        private void txtTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
