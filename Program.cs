/*
The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

Create 4, or more, exercises.
Create 3, or more, cohorts.
Create 4, or more, students and assign them to one of the cohorts.
Create 3, or more, instructors and assign them to one of the cohorts.
Have each instructor assign 2 exercises to each of the students.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // COHORTS
            Cohort Cohort26 = new Cohort()
            {
                CohortName = "Cohort 26",
            };

            Cohort Cohort27 = new Cohort()
            {
                CohortName = "Cohort 27",
            };

            Cohort Cohort28 = new Cohort()
            {
                CohortName = "Cohort 28",
            };

            // STUDENTS
            Student Daniel = new Student()
            {
                FirstName = "Daniel",
                LastName = "Figueroa",
                SlackHandle = "Daniel Figueroa",
                StudentCohort = Cohort27,
            };
            Student Ricky = new Student()
            {
                FirstName = "Ricky",
                LastName = "Bruner",
                SlackHandle = "Ricky Brunder",
                StudentCohort = Cohort27,
            };
            Student Adelaide = new Student()
            {
                FirstName = "Adelaide",
                LastName = "Yoder",
                SlackHandle = "Adelaide Yoder",
                StudentCohort = Cohort26,
            };
            Student Jennifer = new Student()
            {
                FirstName = "Jennifer",
                LastName = "Lawson",
                SlackHandle = "Jennifer Lawson",
                StudentCohort = Cohort26,
            };
            Student John = new Student()
            {
                FirstName = "John",
                LastName = "Wood",
                SlackHandle = "John Wood",
                StudentCohort = Cohort28,
            };

            // INSTRUCTORS
            Instructor Brenda = new Instructor()
            {
                FirstName = "Brenda",
                LastName = "Long",
                SlackHandle = "Brenda Long",
                InstructorCohort = Cohort27,
            };
            Instructor Jisie = new Instructor()
            {
                FirstName = "Jisie",
                LastName = "David",
                SlackHandle = "Jisie David",
                InstructorCohort = Cohort26,
            };
            Instructor Steve = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "Steve Brownlee",
                InstructorCohort = Cohort27,
            };

            // ExerciseS
            Exercise ExerciseHTML = new Exercise()
            {
                ExerciseName = "HTML",
                ExerciseLanguage = "HTML"
            };
            Exercise ExerciseSets = new Exercise()
            {
                ExerciseName = "Sets",
                ExerciseLanguage = "C#"
            };
            Exercise ExerciseDictionaries = new Exercise()
            {
                ExerciseName = "Dictionaries",
                ExerciseLanguage = "C#"
            };
            Exercise ExerciseNutshell = new Exercise()
            {
                ExerciseName = "Nutshell",
                ExerciseLanguage = "Javascript"
            };

            // Assigning Excersises to Students
            Brenda.AssignStudent(ExerciseHTML, Daniel);
            Brenda.AssignStudent(ExerciseNutshell, Ricky);
            Brenda.AssignStudent(ExerciseDictionaries, Ricky);

            // For this Exercise, you need to create 4 new List instances to Program.cs: one to contain students, one to contain Exercises, one to contain instructors, and one to contain cohorts.
            List<Student> StudentList = new List<Student>();
            StudentList.Add(Daniel);
            StudentList.Add(Ricky);
            StudentList.Add(Adelaide);
            StudentList.Add(Jennifer);
            StudentList.Add(John);

            List<Exercise> ExerciseList = new List<Exercise>();
            ExerciseList.Add(ExerciseHTML);
            ExerciseList.Add(ExerciseSets);
            ExerciseList.Add(ExerciseDictionaries);
            ExerciseList.Add(ExerciseNutshell);

            List<Instructor> InstructorList = new List<Instructor>();
            InstructorList.Add(Brenda);
            InstructorList.Add(Jisie);
            InstructorList.Add(Steve);

            List<Cohort> CohortList = new List<Cohort>();
            CohortList.Add(Cohort26);
            CohortList.Add(Cohort27);
            CohortList.Add(Cohort28);

            // List exercises for the JavaScript language by using the Where() LINQ method.
            var filteredExercise = ExerciseList.Where(e => e.ExerciseLanguage == "Javascript").ToList();
            foreach(Exercise e in filteredExercise) {
            Console.WriteLine($"{e.ExerciseName}");
            }

            Console.WriteLine("--------------------------------------");

            // List students in a particular cohort by using the Where() LINQ method.
            var filteredStudent = StudentList.Where(s => s.StudentCohort == Cohort27).ToList();
            foreach(Student e in filteredStudent) {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
            }

            Console.WriteLine("--------------------------------------");

            // List instructors in a particular cohort by using the Where() LINQ method.
            var filteredInstructor = InstructorList.Where(s => s.InstructorCohort == Cohort27).ToList();
            foreach(Instructor e in filteredInstructor) {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
            }

            Console.WriteLine("--------------------------------------");
            
            // Sort the students by their last name.
            var SortedByLastName = StudentList.OrderByDescending(b => b.LastName);
            foreach(Student e in SortedByLastName) {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
            }

            Console.WriteLine("--------------------------------------");

            // Display any students that aren't working on any exercises
            var filteredStudent2 = StudentList.Where(e => e.StudentsExercises.Count() == 0).ToList();
            foreach(Student e in filteredStudent2) {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
            }

            Console.WriteLine("--------------------------------------");

            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            var filteredStudent3 = StudentList.OrderByDescending(e => e.StudentsExercises.Count).Take(1);
            foreach(Student e in filteredStudent3) {
            Console.Write($"{e.FirstName} {e.LastName}");
            };
            // Could have also done this
            // var filteredStudent3 = StudentList.OrderByDescending(e => e.StudentsExercises.Count).First();
            // Console.WriteLine($"{filteredStudent3.SlackHandle}");

            Console.WriteLine("--------------------------------------");

            //How many students in each cohort?
            // var results = from student in StudentList
            // group student.SlackHandle by student.StudentCohort into g
            // select new { Cohort = g.Key, Name = g.ToList() };
            // foreach(var e in results) {
            //     Console.WriteLine($"{e.Cohort.CohortName}: {e.Name}");
            // }
            var results = StudentList.GroupBy(e => e.StudentCohort.CohortName);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} has {item.Count()}");
            }





            Console.WriteLine("--------------------------------------");

            SqliteConnection db = DatabaseInterface.Connection;
            DatabaseInterface.CheckExerciseTable();

            // Query the database for all the Exercises.
            db.Query<Exercise>(@"SELECT * FROM Exercise")
            .ToList()
            .ForEach(ex => Console.WriteLine($"Exercise: {ex.ExerciseName}, written in {ex.ExerciseLanguage}"));

            Console.WriteLine("--------------------------------------");

            // Find all the exercises in the database where the language is JavaScript.
            db.Query<Exercise>(@"SELECT * FROM Exercise")
            .Where(ex => ex.ExerciseLanguage == "Javascript")
            .ToList()
            .ForEach(ex => Console.WriteLine($"Exercise: {ex.ExerciseName}, written in {ex.ExerciseLanguage}"));

            Console.WriteLine("--------------------------------------");

            // Insert a new exercise into the database.
                    // db.Execute(@"
                    //     INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
                    //     VALUES ('Map', 'Javascript')");
                    // db.Query<Exercise>(@"SELECT * FROM Exercise")
                    // .Where(ex => ex.ExerciseLanguage == "Javascript")
                    // .ToList()
                    // .ForEach(ex => Console.WriteLine($"Exercise: {ex.ExerciseName}, written in {ex.ExerciseLanguage}"));
            
            Console.WriteLine("--------------------------------------");

            // Find all instructors in the database. Include each instructor's cohort.
            IEnumerable<Instructor> instructor2 = db.Query<Instructor, Cohort, Instructor>(@"
            SELECT 
                i.Id,
                i.FirstName,
                i.LastName,
                i.SlackHandle,
                i.InstructorCohortId,
                c.Id,
                c.CohortName
            FROM Instructor i
            JOIN Cohort c ON c.Id = i.InstructorCohortId",(instructor, cohort) => {
                instructor.InstructorCohort = cohort;
                return instructor;
            });

            foreach (Instructor ins in instructor2)
            {
                Console.WriteLine($"{ins.FirstName} {ins.LastName} teaches {ins.InstructorCohort.CohortName}");
            }

            Console.WriteLine("--------------------------------------");

            // Insert a new instructor into the database. Assign the instructor to an existing cohort.
            // db.Execute(@"
            //     INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
            //     VALUES ('Andy', 'Collins', 'Andy Collins', 2)");
            db.Query<Instructor, Cohort, Instructor>(@"
            SELECT 
                i.Id,
                i.FirstName,
                i.LastName,
                i.SlackHandle,
                i.InstructorCohortId,
                c.Id,
                c.CohortName
            FROM Instructor i
            JOIN Cohort c ON c.Id = i.InstructorCohortId",(instructor, cohort) => {
                instructor.InstructorCohort = cohort;
                return instructor;
            }).ToList().ForEach(ins => Console.WriteLine($"{ins.FirstName} {ins.LastName} teaches {ins.InstructorCohort.CohortName}"));

            Console.WriteLine("--------------------------------------");

            // Assign an existing exercise to an existing student.
            DatabaseInterface.CheckAssignedExerciseTable();
            // db.Execute(@"
            //     INSERT INTO AssignedExercise (StudentId, ExerciseId)
            //     VALUES ('2', '2');
            // ");

            // Challenge - Find all the students in the database. Include each student's cohort AND each student's list of exercises.
            Dictionary<Student, List<Exercise>> CulminatedExercise = new Dictionary<Student, List<Exercise>>();

            db.Query<Student, Cohort, Exercise, Student>(@"
            SELECT 
                s.Id,
                s.FirstName,
                s.LastName,
                s.SlackHandle,
                s.StudentCohortId,
                c.Id,
                c.CohortName,
                e.Id,
                e.ExerciseName,
                e.ExerciseLanguage
            FROM Student s
            JOIN AssignedExercise ae ON ae.StudentId = s.Id
            JOIN Cohort c ON c.Id = s.StudentCohortId
            JOIN Exercise e ON e.Id = ae.ExerciseId",(student, cohort, exercise) => {
                if (!CulminatedExercise.ContainsKey(student)) {
                        student.StudentCohort = cohort;
                        CulminatedExercise[student] = new List<Exercise>();
                    }
                    CulminatedExercise[student].Add(exercise);
                    return student;});
            
            foreach(KeyValuePair<Student, List<Exercise>> ex in CulminatedExercise)
                {
                    Console.WriteLine($"{ex.Key.SlackHandle} is in {ex.Key.StudentCohort.CohortName} and is working:");
                    foreach (Exercise item in ex.Value)
                    {
                        Console.WriteLine($"{item.ExerciseName}  written in {item.ExerciseLanguage}");
                    }
                }
    }
    }
}
