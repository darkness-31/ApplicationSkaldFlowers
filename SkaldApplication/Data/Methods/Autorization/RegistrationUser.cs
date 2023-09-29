using SkaldApplication.Until;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkaldApplication.Data.Authorization
{
    internal partial class RegistrationUser
    {
        AccountUser account = new AccountUser();

        public bool IsExistAccount()
        {
            account.Login = this.Login;
            account.Password = this.Password;

            return account.ExistAccount();
        }

        public bool Create()
        {
            var sql = $@"INSERT INTO spr_account (login, password) VALUES
                          ('{this.Login}','{this.Password}')
                         RETURNING id";
            var AccountId = sql.SQLQueryAsDataTable().Rows[0]["id"].ToString();

            sql = $@"INSERT INTO spr_document (passport, inn, snils) VALUES 
                        ('{this.Passport}','{this.Inn}','{this.Snils}')
                     RETURNING id";
            var DocumentId = sql.SQLQueryAsDataTable().Rows[0]["id"].ToString();

            sql = $@"INSERT INTO spr_person (first_name, middle_name, last_name, id_spr_job, id_spr_document, id_spr_sex, id_spr_account)
                            VALUES
                                ('{this.FirstName}','{this.MiddleName}','{this.LastName}',{this.Job},{DocumentId},{this.Sex},{AccountId})";
            sql.SQLNoneQuery();

            return true;
        }
    }
}
