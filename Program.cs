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
            var filtered = ExerciseList.Where(e => e.ExerciseLanguage == "Javascript").ToList();
            foreach(Exercise e in filtered) {
            Console.WriteLine($"{e.ExerciseName}");

            }
        }
    }
}
