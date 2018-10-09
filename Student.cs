/*
You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time.

Properties
First name
Last name
Slack handle
The student's cohort
The collection of exercises that the student is currently working on
*/
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public Student()
        {
            StudentsExercises =  new List<Excercise>();
        }
        public string FirstName;
        public string LastName;
        public string SlackHandle;
        public int StudentCohort;
        public List<Excercise> StudentsExercises;
    }
}