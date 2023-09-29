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
        /// <summary>
        /// Берёт из базы данных информацию о его допуске
        /// </summary>
        /// <returns><see cref="AccountAccess"/></returns>
        public AccountAccess GetAccess()
        {
            var sql = $@"SELECT a.id_spr_access
                        FROM spr_account AS a
                        WHERE a.login = '{_Login}' AND 
                        	   a.PASSWORD = '{_Password}'";

            var value = sql.SQLQueryAsDataTable().Rows[0][0];
            if (value is null)
                return AccountAccess.Anonim;

            return (AccountAccess)value;
        }
        /// <summary>
        /// Проверяет есть ли такой пользователь в базе
        /// </summary>
        /// <returns>Если есть, то <see langword="true"/>, иначе <see langword="false"/></returns>
        public bool ExistAccount()
        {
            var sql = $@"SELECT COUNT(*) > 0
                         FROM spr_account
                         WHERE login = '{Login}' AND 
                               password = '{Password}'";
            return (bool)sql.SQLQueryAsDataTable().Rows[0][0];
        }
        /// <summary>
        /// Cпециальный метод для конструкции <see langword="using"/>
        /// <example>
        /// <para/>
        /// <para/>
        /// Пример использования:
        /// <code>
        /// <see langword="using"/>(<see cref="AccountUser"/> account = <see langword="new"/> <see cref="AccountUser"/>()) {
        ///         ...
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public void Dispose()
        {
            _Login = string.Empty;
            _Password = string.Empty;
            _Access = AccountAccess.Anonim;
            GC.Collect();
        }
    }
}
