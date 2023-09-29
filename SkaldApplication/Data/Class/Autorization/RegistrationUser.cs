using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SkaldApplication.Data.Authorization
{
    internal partial class RegistrationUser
    {
        string _Login { get; set; }
        string _Password { get; set; }
               
        string _Inn { get; set; }
        int[] _InnMultiEleven = new[] { 7,2,4,10,3,5,9,4,6,8 };
        int[] _InnMultiTwelve = new[] { 3,7,2,4,10,3,5,9,4,6,8 };
        string _Snils { get; set; }
        string _Passport { get; set; }
               
        string _FirstName { get; set; }
        string _LastName { get; set; }
        string _MiddleName { get; set; }

        public string Login 
        {
            get => _Login; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new NullReferenceException("Нет значения");
                if  (value.Length >= 50 ||
                     value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("За пределами от 4 до 50 включительно");
                }
                
                _Login = value;
            }
        }
        public string Password 
        { 
            get => _Password; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new NullReferenceException("Нет значения");
                if (value.Length < 8 ||
                    value.Length >= 256)
                {
                    throw new ArgumentOutOfRangeException("За пределами от 8 до 256 включительно");
                }
            }
        }

        public string Inn 
        { 
            get => _Inn;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Inn = string.Empty;
                    return;
                }

                var innMulti = new int[] { };
                if (value.Length == 11)
                    innMulti = _InnMultiEleven;
                else if (value.Length == 12)
                    innMulti = _InnMultiTwelve;
                else if (value.Length == 10)
                    throw new ArgumentException("Укажите ИНН физического лица");
                else
                    throw new FormatException("Неправильный формат ИНН");

                int sum = 0;
                for (int i = 0; i < innMulti.Length; i++)
                {
                    sum += int.Parse(value[i].ToString()) * innMulti[i];
                }
                int celoe = sum % 11 % 10;

                if (celoe.ToString() != value[value.Length - 1].ToString())
                    throw new ArgumentException("Неправильный ИНН");

                _Inn = value;
            }
        }
        public string Snils 
        {
            get => _Snils;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Snils = string.Empty;
                    return;
                }
                if (value.Length < 11)
                    throw new ArgumentOutOfRangeException("Не полное значение");

                var csum = int.Parse(string.Join("",value.Skip(value.Length-2).ToArray()));
                int sum = 0;
                for (int i = 0;i < value.Length; i++)
                {
                    sum += value[i] * 9 - i;
                }
                bool ans = false;
                while (sum < 100) {
                    if (sum < 100)
                    {
                        ans = sum == csum;
                    }
                    else if (sum == 100 || sum == 101)
                    {
                        ans = sum == 0;
                    }

                    sum -= 101;
                }

                if (ans)
                {
                    _Snils = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный номер снился");
                }
            } 
        }
        public string Passport 
        {
            get => _Passport;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Нет значения");

                if (value.Length != 10)
                    throw new ArgumentException("Не полная серия или не полный номер паспорта");
                
                _Passport = value;
            }
        }

        public string FirstName 
        {
            get => _FirstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Нет значения");
                if (value.Length < 2)
                    throw new ArgumentException("Слишком маленькое имя");

                _FirstName = value;
            }
        }
        public string LastName
        {
            get => _LastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Нет значения");
                if (value.Length < 2)
                    throw new ArgumentException("Слишком маленькая фамилия");

                _LastName = value;
            }
        }
        public string MiddleName
        {
            get => _MiddleName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _MiddleName = string.Empty;
                    return;
                }
                if (value.Length < 2)
                    throw new ArgumentException("Слишком маленькое отчество");

                _MiddleName = value;
            }
        }
        public int Sex { get; set; }
        public int Job {  get; set; }


    }
}
