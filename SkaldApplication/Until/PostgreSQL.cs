﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaldApplication.Until
{
    internal static class PostgreSQL
    {
        private static NpgsqlConnection _DB;
        public static void CreateConnection(string server = "127.0.0.1",
                                       string port = "5432",
                                       string user = "postgres",
                                       string password = "",
                                       string database = "postgres")
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Нет пароля");
            }

            _DB = new NpgsqlConnection($@"Host={server}; 
                                          Port={port}; 
                                          Username={user}; 
                                          Password={password}; 
                                          Database={database}");
        }

        public static async void Open() => await _DB.OpenAsync();
        public static async void Close() => await _DB.CloseAsync();

        public static DataTable SQLQuery(this string sql)
        {
            NpgsqlDataAdapter command = new NpgsqlDataAdapter(sql, _DB);
            DataTable dt = new DataTable();
            command.Fill(dt);
            return dt;
        }
        public static IEnumerable<dynamic> SQLQuery(this string sql, params string[] parametrs)
        {
            return default;
        }
        public static async void SQLNoneQuery(this string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql, _DB);
            await command.ExecuteNonQueryAsync();
        }
    }
}
