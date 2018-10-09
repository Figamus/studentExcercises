/*
You must define a type for representing a cohort in code.

The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
The collection of students in the cohort.
The collection of instructors in the cohort.
*/
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public Cohort ()
        {
            Students = new List<Student>();
            Instructors = new List<Instructor>();
        }
        public string CohortName;
        List<Student> Students;
        List<Instructor> Instructors;
    }
}