using SkaldApplication.Data.Authorization;
using System;
using System.Text;
using System.Windows.Forms;

namespace SkaldApplication.Forms.Elements
{
    internal partial class UserControlEnterAccounts : UserControl
    {
        public string Login
        {
            get => TextBoxLogin.Text;
        }
        public string Password
        {
            get => TextBoxPassword.Text;
        }

        internal delegate void EnteredAccount(AccountUser account);
        /// <summary>
        /// Событие возникает, когда авторизация пользователя прошла успешна
        /// </summary>
        internal event EnteredAccount EnteredAccountHandler;

        public UserControlEnterAccounts()
        {
            InitializeComponent();
        }

        private void ButtoEntered_Click(object sender, EventArgs e)
        {
            try
            {
                AccountUser account = new AccountUser();
                account.Login = Login;
                account.Password = Password;

                if (account.ExistAccount())
                {
                    EnteredAccountHandler(account);
                }
                else
                {
                    LabelError.Text = "Неправильный логин или пароль";
                }
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
        }
    }
}
