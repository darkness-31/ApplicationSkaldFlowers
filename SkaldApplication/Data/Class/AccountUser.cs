using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkaldApplication.Data.Enums;
using SkaldApplication.Until;

namespace SkaldApplication.Data.Class
{
    internal class AccountUser : IDisposable
    {
        private string _Login { get; set; }
        private string _Password { get; set; }
        private AccountAccess _Access { get; set; }

        public string Login 
        { 
            get 
            {
                return _Login;
            } 
            set {

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Пустой логин");
                else if (value.Length >= 25)
                    throw new ArgumentOutOfRangeException("Слишком много символов в логине");
                else if (value.Length < 5)
                    throw new ArgumentOutOfRangeException("Слишком слишком мало символов в логине");

                _Login = value;
            }
        }
        public string Password 
        { 
            get
            {
                return _Password;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Пустой пароль");
                else if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Слишком большой пароль");
                else if (value.Length < 8)
                    throw new ArgumentOutOfRangeException("Слишком маленький пароль");

                _Password = value;
            } 
        }

        public AccountAccess GetAccess()
        {
            var sql = $@"SELECT a.id_spr_access
                        FROM spr_account AS a
                        WHERE a.login = '{_Login}' AND 
                        	   a.PASSWORD = '{_Password}'";

            var value = sql.SQLQuery().Rows[0][0];
            if (value is null)
                return AccountAccess.Anonim;

            return (AccountAccess)value;
        }

        public void Dispose()
        {
            _Login = string.Empty;
            _Password = string.Empty;
            _Access = AccountAccess.Anonim;
        }
    }
}
