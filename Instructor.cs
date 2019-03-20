using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class Instructor
    {
        public Instructor(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}