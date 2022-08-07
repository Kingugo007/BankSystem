using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BankSystem
{

    public partial class ChooseAccount : Form
    {
        private readonly IAccountServices _accountServices;
        private readonly IUserDTO _userDTO;
        private IServiceProvider _serviceProvider;
        private readonly IAccountDTO _accountDTO;
        public ChooseAccount(IServiceProvider serviceProvider, IAccountServices accountServices, IUserDTO userDTO, IAccountDTO accountDTO)
        {
            InitializeComponent();
            _accountServices = accountServices;
            _userDTO = userDTO;
            _serviceProvider = serviceProvider;
            _accountDTO = accountDTO;   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnChooseAccount_Click(object sender, EventArgs e)
        {
            User loggedUser = _userDTO.LoggedUser;
            string option = string.Empty;
            if (Savings.Checked)
            {
                option = Savings.Text;
            }
            else
            {
                option = Current.Text;
            }

            var account = new Account
            {                
                Name = loggedUser.FullName,
                AccountNumber = CreateAccNumber.accNumber(),
                Balance = 0,
                UserId = loggedUser.Id,
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
                dashboard.Show();
            }



        }
    }
}
