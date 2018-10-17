using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace StudentExercises
{
    public class DatabaseInterface
    {
        public static SqliteConnection Connection
        {
            get
            {
                string connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(connectionString);
            }
        }
        public static void CheckExerciseTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;
            try
            {
                List<Exercise> retrievedExercises = db.Query<Exercise>
                ("Select Id From Exercise").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute($@"CREATE TABLE `Exercise` (
                        `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        `ExerciseName`    TEXT NOT NULL,
                        `ExerciseLanguage`    TEXT NOT NULL,
                    )");
                }
            }
        }
    }
}