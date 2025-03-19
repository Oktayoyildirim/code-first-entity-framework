using System;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Create a new student
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // Add the student to the database
            context.Students.Add(student);
            context.SaveChanges();

            // Output the student's details
            Console.WriteLine($"Student {student.FirstName} {student.LastName} added to the database with ID: {student.Id}");
        }
    }
}
