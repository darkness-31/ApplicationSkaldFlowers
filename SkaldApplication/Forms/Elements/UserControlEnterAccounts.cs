using SkaldApplication.Data.Class;
using System;
using System.Windows.Forms;

namespace SkaldApplication.Forms.Elements
{
    public partial class UserControlEnterAccounts : UserControl
    {
        public UserControlEnterAccounts()
        {
            InitializeComponent();
        }

        private void ButtoEntered_Click(object sender, EventArgs e)
        {
            try
            {
                AccountUser account = new AccountUser();
                account.Login = TextBoxLogin.Text;
                account.Password = TextBoxPassword.Text;
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
        }
    }
}
