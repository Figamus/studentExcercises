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
        public static void CheckInstructorTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;
            try
            {
                List<Instructor> retrievedInstructors = db.Query<Instructor>
                ("Select Id From Instructor").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute($@"CREATE TABLE `Instructor` (
                        `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        `FirstName`    TEXT NOT NULL,
                        `LastName`    TEXT NOT NULL,
                        `SlackHandle` TEXT NOT NULL,
                        `CohortId` INTEGER NOT NULL
                    )");
                }
            }
        }
        public static void CheckAssignedExerciseTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;
            try
            {
                List<AssignedExercise> retrievedInstructors = db.Query<AssignedExercise>
                ("Select Id From AssignedExercise").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    Console.WriteLine("No Such Table. Creating new Table.");
                    db.Execute($@"CREATE TABLE `AssignedExercise` (
                        `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        `StudentId` INTEGER NOT NULL,
                        `CohortId` INTEGER NOT NULL
                    )");
                }
            }
        }
    }
}