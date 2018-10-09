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

            // EXCERCISES
            Excercise ExcerciseHTML = new Excercise()
            {
                ExcerciseName = "HTML",
                ExcerciseLanguage = "HTML"
            };
            Excercise ExcerciseSets = new Excercise()
            {
                ExcerciseName = "Sets",
                ExcerciseLanguage = "C#"
            };
            Excercise ExcerciseDictionaries = new Excercise()
            {
                ExcerciseName = "Dictionaries",
                ExcerciseLanguage = "C#"
            };
            Excercise ExcerciseNutshell = new Excercise()
            {
                ExcerciseName = "Nutshell",
                ExcerciseLanguage = "Javascript"
            };

            // Assigning Excersises to Students
            Brenda.AssignStudent(ExcerciseHTML, Daniel);
            Brenda.AssignStudent(ExcerciseNutshell, Ricky);
        }
    }
}
