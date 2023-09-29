using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkaldApplication.Data.Enums;
using SkaldApplication.Until;

namespace SkaldApplication.Data.Authorization
{
    /// <summary>
    /// Аккаунт пользователя
    /// </summary>
    internal partial class AccountUser : IDisposable
    {
        private string _Login { get; set; }
        private string _Password { get; set; }
        private AccountAccess _Access { get; set; }

        /// <summary>
        /// Логин для входа
        /// </summary>
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
        /// <summary>
        /// Пароль для входа
        /// </summary>
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
    }
}
