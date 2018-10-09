/*
You must define a type for representing an instructor in code.

First name
Last name
Slack handle
The instructor's cohort
A method to assign an exercise to a student
*/
using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName;
        public string LastName;
        public string SlackHandle;
        public int CohortNumber;

        public void AssignStudent()
        {
            Console.WriteLine("");
        }
    }
}