﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Millionaire
{
    class QuizController
    {
        private readonly string connectionString = DatabaseManager.connectionString;

        public Question GetRandomQuestion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM question ORDER BY RAND() LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Question
                            {
                                Id = reader.GetInt32("id"),
                                Text = reader.GetString("text"),
                                Difficulty = reader.GetInt32("difficulty"),
                                Area = reader.GetString("area")
                            };
                        }
                    }
                }
            }

            return null;
        }

        public List<Answer> GetAnswersForQuestion(int questionId)
        {
            List<Answer> answers = new List<Answer>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM answer WHERE questionId = @questionId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@questionId", questionId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            answers.Add(new Answer
                            {
                                Id = reader.GetInt32("id"),
                                Text = reader.GetString("text"),
                                CorrectAnswer = reader.GetBoolean("correctAnswer"),
                                QuestionId = reader.GetInt32("questionId")
                            });
                        }
                    }
                }
            }

            return answers;
        }
    }
}