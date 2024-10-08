using System;

namespace EmployeeComparison
{
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null references first
            if (Object.ReferenceEquals(emp1, null) || Object.ReferenceEquals(emp2, null))
                return Object.ReferenceEquals(emp1, emp2);
            
            // Compare Ids to determine if the two Employee objects are equal
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator, required to be overloaded when == is overloaded
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the negation of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals method as a best practice when overloading ==
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            Employee other = obj as Employee;
            return this.Id == other.Id;
        }

        // Override GetHashCode method whenever Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
