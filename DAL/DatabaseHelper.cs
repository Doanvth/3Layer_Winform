﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = "Server=.;Database=DuAnMau;Trusted_Connection=True;";
        //Datasource
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
