﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WpfApp11
{
    class SqliteDataAccess
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection() { ConnectionString = @"Data Source = DemoDB.db;Version=3;" };
        }
    }
}
