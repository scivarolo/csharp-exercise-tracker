using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise kennel = new Exercise("React Kennel", "React");
            Exercise lootbag = new Exercise("Bag o' Loot", "Python");
            Exercise chinook = new Exercise("Chinook", "SQL");
            Exercise stocks = new Exercise("Stock Trading", "Python");

            Cohort cohort28 = new Cohort("Cohort 28");
            Cohort cohort29 = new Cohort("Cohort 29");
            Cohort cohort30 = new Cohort("Cohort 30");

            Student elyse = new Student("Elyse", "Dawson", cohort28);
            Student kelly = new Student("Kelly", "Morin", cohort28);
            Student nolan = new Student("Nolan", "Little", cohort29);
            Student alfonso = new Student("Alfonso", "Miranda", cohort29);
            Student bryan = new Student("Bryan", "Nilsen", cohort30);
            Student brendan = new Student("Brendan", "McCray", cohort30);

            Instructor joe = new Instructor("Joe", "Shepherd");
            Instructor jisie = new Instructor("Jisie", "David");
            Instructor steve = new Instructor("Steve", "Brownlee");

            joe.AssignExercise(elyse, kennel);
            joe.AssignExercise(elyse, chinook);
            joe.AssignExercise(kelly, chinook);
            joe.AssignExercise(kelly, lootbag);
            jisie.AssignExercise(nolan, chinook);
            jisie.AssignExercise(nolan, stocks);
            jisie.AssignExercise(alfonso, stocks);
            jisie.AssignExercise(alfonso, kennel);
            steve.AssignExercise(bryan, lootbag);
            steve.AssignExercise(bryan, stocks);
            steve.AssignExercise(brendan, chinook);
            steve.AssignExercise(brendan, kennel);

            List<Student> students = new List<Student> () {
                elyse,
                kelly,
                nolan,
                alfonso,
                bryan,
                brendan
            };

            List<Exercise> exercises = new List<Exercise> () {
                kennel,
                lootbag,
                chinook,
                stocks
            };

            // Let's build up a dictionary to hold a list of students assigned to each exercise.
            Dictionary<Exercise, List<Student>> assignedExercises = new Dictionary<Exercise, List<Student>> ();

            foreach (Exercise exercise in exercises)
            {
                assignedExercises.Add(exercise, new List<Student>());
            }

            // Loop through each student's exercises and add them to the dictionary
            foreach (Student student in students)
            {
                foreach (Exercise exercise in student.Exercises)
                {
                    assignedExercises[exercise].Add(student);
                }
            }

            // Print report of students assigned to each exercise
            foreach (KeyValuePair<Exercise, List<Student>> exercise in assignedExercises)
            {
                string exerciseName = exercise.Key.Name;
                string assignedStudents = "";

                foreach (Student student in exercise.Value)
                {

                    if (exercise.Value.IndexOf(student) == exercise.Value.Count - 1)
                    {
                        assignedStudents += $"and {student.FullName}";
                    }
                    else
                    {
                        assignedStudents += student.FullName;
                        assignedStudents += ", ";
                    }
                }

                Console.WriteLine($"{assignedStudents} are working on {exerciseName} in {exercise.Key.Language}");
            }
        }
    }
}
