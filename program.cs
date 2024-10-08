using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object
            Employee emp1 = new Employee
            {
                Id = 1,           // Assign unique ID
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate the second Employee object
            Employee emp2 = new Employee
            {
                Id = 2,           // Assign different ID from emp1
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The employees are considered equal.");
            }
            else
            {
                Console.WriteLine("The employees are not considered equal.");
            }

            // Compare the two Employee objects using the overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("The employees are considered different.");
            }
            else
            {
                Console.WriteLine("The employees are considered the same.");
            }

            Console.ReadKey(); // Wait for a key press before exiting
        }
    }
}
