using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class Student
    {
        public Student(string firstName, string lastName, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            Cohort = cohort;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise> ();

        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}