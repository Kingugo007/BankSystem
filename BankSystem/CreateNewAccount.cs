using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BankSystem
{
    public partial class CreateNewAccount : Form
    {
        private readonly IAccountServices _accountServices;
        private readonly IAccountDTO _accountDTO;
        private IServiceProvider _serviceProvider;
        public CreateNewAccount(IAccountServices accountServices, IAccountDTO accountDTO, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _accountServices = accountServices;
            _accountDTO = accountDTO;
            _serviceProvider = serviceProvider; 
        }

        private async void txtEnter_Click(object sender, EventArgs e)
        {
            Account loggedUser = _accountDTO.LoggedAccount;
            string option = string.Empty;
            if (Savings2.Checked)
            {
                option = Savings2.Text;
            }
            else
            {
                option = Current2.Text;
            }
            var account = new Account
            {
                Name = loggedUser.Name,
                AccountNumber = CreateAccNumber.accNumber(),
                Balance = 0,
                UserId = loggedUser.UserId,
                AccountType = option,
            };

            var result = await _accountServices.CreateAcc(account);
            if (result)
            {
                _accountDTO.LoggedAccount = account;
                MessageBox.Show("Account created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = _serviceProvider.GetRequiredService<Dashboard>();
                dashboard.name = _accountDTO.LoggedAccount.Name;
                dashboard.balance = _accountDTO.LoggedAccount.AccountNumber.ToString();
                this.Close();
            }
        }
    }
}
