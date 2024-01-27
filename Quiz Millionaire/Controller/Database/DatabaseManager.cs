using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_Millionaire
{
    class DatabaseManager
    {
        private readonly string connectionString = $"Server=localhost;Database={DatabaseConfig.DBName};User ID={DatabaseConfig.UserID};Password={DatabaseConfig.Password}";

    }
}
