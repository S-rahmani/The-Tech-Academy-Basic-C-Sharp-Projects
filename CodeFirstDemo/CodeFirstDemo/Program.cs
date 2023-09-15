using System;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the SchoolContext
            using (var context = new SchoolContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}