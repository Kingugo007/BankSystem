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
    public partial class Login : Form
    {
        private readonly IUserServices _userService;
        private readonly IValidators _validate;
        private readonly IUtilities _utility;
        private readonly IUserDTO _userDTO;
        private readonly IAccountDTO _accountDTO;
        private IServiceProvider _serviceProvider;
          
        public Login(IServiceProvider serviceProvider, IUserServices userServices, IValidators validators, IUtilities utilities, IUserDTO userDTO, IAccountDTO accountDTO)
        {
            InitializeComponent();
            _userService = userServices;
            _validate = validators;
            _utility = utilities;
            _serviceProvider = serviceProvider;
            _userDTO = userDTO;
            _accountDTO = accountDTO;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (!_validate.CheckEmail(email))
            {
                MessageBox.Show("Please enter a valid email", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_validate.CheckPassword(password))
            {
                MessageBox.Show("Please enter a vaild password", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                var result = await _userService.Login(email, password);
                if (!result.Status)
                {
                    MessageBox.Show(result.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _accountDTO.LoggedAccount = (Account)result.Data!;
                    MessageBox.Show(result.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = _serviceProvider.GetRequiredService<Dashboard>();
                    dashboard.name = _accountDTO.LoggedAccount.Name;
                    dashboard.balance = _accountDTO.LoggedAccount.AccountNumber;
                    dashboard.Show();
                  
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Emailinput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        Control ctrl;
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);

                }
                else
                    return;
            }
        }

      
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void gotoregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome welcome = _serviceProvider.GetRequiredService<Welcome>();
            welcome.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
