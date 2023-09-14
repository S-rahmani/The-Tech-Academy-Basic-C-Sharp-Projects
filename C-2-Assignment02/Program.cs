using System;

// Create an interface called IQuittable
public interface IQuittable
{
    void Quit();
}

// Modify the Employee class to implement the IQuittable interface
public class Employee : IQuittable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the company.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee(1, "John", "Doe");

        // Create an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the IQuittable object
        quittableEmployee.Quit();

        // The output will be: "John Doe has quit the company."
    }
}