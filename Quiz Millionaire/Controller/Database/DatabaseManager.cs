using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_Millionaire
{
    class DatabaseManager
    {
        public static readonly string connectionString = $"Server=localhost;Database={DatabaseConfig.DBName};User ID={DatabaseConfig.UserID};Password={DatabaseConfig.Password}";

        public List<T> GetAll<T>(string tableName) where T : new()
        {
            List<T> entities = new List<T>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var properties = typeof(T).GetProperties();

                string query = $"SELECT * FROM {tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = new T();

                            foreach (var property in properties)
                            {
                                object valueFromDatabase = reader[property.Name] is DBNull ? null : reader[property.Name];

                                if (property.Name == "CorrectAnswer" && valueFromDatabase != null)
                                {
                                    valueFromDatabase = ConvertSByteToBoolean(valueFromDatabase);
                                }

                                property.SetValue(entity, valueFromDatabase);
                            }

                            entities.Add(entity);
                        }
                    }
                }
            }

            return entities;
        }

        public void Create<T>(T entity, string tableName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var properties = typeof(T).GetProperties();
                var propertyNames = string.Join(", ", properties.Select(p => p.Name));
                var valuePlaceholders = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                string query = $"INSERT INTO {tableName} ({propertyNames}) VALUES ({valuePlaceholders})";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    foreach (var property in properties)
                    {
                        command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity) ?? DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update<T>(T entity, string tableName, string column, object value)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var properties = typeof(T).GetProperties();
                var setClauses = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

                string query = $"UPDATE {tableName} SET {setClauses} WHERE {column} = @Value";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    foreach (var property in properties)
                    {
                        command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity) ?? DBNull.Value);
                    }

                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete<T>(string tableName, string column, object value)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM {tableName} WHERE {column} = @Value";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }

        private bool ConvertSByteToBoolean(object value)
        {
            if (value is sbyte sbyteValue)
            {
                return sbyteValue != 0;
            }

            return false;
        }
    }
}
