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
    public partial class Welcome : Form
    {
        private readonly IUserServices _userService;
        private readonly IValidators _validate;
        private readonly IUtilities _utility;
        private readonly IUserDTO _userDTO;
        private IServiceProvider _serviceProvider;

        public Welcome(IServiceProvider serviceProvider, IUserServices userService, IValidators validator, IUtilities utilities, IUserDTO userDTO)
        {
            InitializeComponent();
            _userService = userService;
            _validate = validator;
            _utility = utilities;
            _userDTO = userDTO;
            _serviceProvider = serviceProvider;
        }

        private void FName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LNinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emailinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FNinput_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string hashPassword = _utility.ComputeSha256Hash(password);
            string phoneNumber = txtPhoneNumber.Text;
            var user = new User
            {
                FirstName = firstName,
                LastName =  lastName,
                Email = email,
                Password = hashPassword,
                Phone = phoneNumber
            };
            if (!_validate.CheckName(firstName))
            {
                MessageBox.Show("Please enter a correct input");
            }
            else if(!_validate.CheckName(lastName))
            {
                MessageBox.Show("Please enter a correct input");
            }
            else if(!_validate.CheckEmail(email))
            {
                MessageBox.Show("Please check you format of email");
            }
            else if(!_validate.CheckPassword(password))
            {
                MessageBox.Show("Password must be six characters containing one special character, one number and one letter");
            }
            else if(!_validate.CheckPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Enter a 11 digit number");
            }
            else 
            {
                var result = await _userService.Register(user);
                if (!result.Status)
                {
                    MessageBox.Show(result.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                
                    _userDTO.LoggedUser = user;
                    MessageBox.Show(result.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChooseAccount chooseAccount = _serviceProvider.GetRequiredService<ChooseAccount>();
                    chooseAccount.Show();
                }               
            } 
          }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Savings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = _serviceProvider.GetRequiredService<Login>();
            login.Show();
        }
    }
}
