using System;

// Create an Employee class
class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize properties
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overload the "==" operator to compare Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects with different Ids
        Employee employee1 = new Employee(1, "John", "Doe");
        Employee employee2 = new Employee(2, "Jane", "Smith");

        // Compare the two Employee objects using the overloaded "==" operator
        if (employee1 == employee2)
        {
            Console.WriteLine("Employee 1 and Employee 2 have the same Id.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 2 have different Ids.");
        }

        // Keep the console window open to see the output
        Console.ReadLine();
    }
}
