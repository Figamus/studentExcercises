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
            StudentsExercises =  new List<Exercise>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int StudentCohortId { get; set; }
        public Cohort StudentCohort { get; set; }
        public List<Exercise> StudentsExercises;
    }
}