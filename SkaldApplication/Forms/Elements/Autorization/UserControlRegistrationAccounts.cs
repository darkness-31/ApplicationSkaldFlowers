using SkaldApplication.Data;
using SkaldApplication.Data.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkaldApplication.Forms.Elements.Autorization
{
    internal partial class UserControlRegistrationAccounts : UserControl
    {
        internal delegate void RegistredHandler(AccountUser account);
        internal event RegistredHandler ComplateRegistredHandler;

        public UserControlRegistrationAccounts() => InitializeComponent();

        dynamic Account {
            get => new
            {
                Login = TextBoxLogin.Text,
                Password = TextBoxPassword.Text == TextBoxPasswordAgain.Text ? TextBoxPassword.Text : string.Empty,
            };
        }
        dynamic Document
        {
            get => new
            {
                inn = TextBoxInn.Text,
                snils = TextBoxSnils.Text,
                pasport = TextBoxPassportNums.Text + TextBoxPassportSeria
            };
        }
        dynamic User
        {
            get => new
            {
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                MiddleName = TextBoxMiddleName.Text,
                Sex = ComboBoxSex.Text,
                Job = ComboBoxJob.Text,
            };
        }


    }
}
