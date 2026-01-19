using System;

namespace OperatorOverloadingAssignment
{
    // The Employee class represents an employee with identifying properties
    public class Employee
    {
        // This is a unique identifier for the employee
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // This overloads the == operator to compare Employee objects
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects reference the same memory location, they are then considered equal
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // However, if either object is null, they cannot be equal
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // This compares employees by their Id properties only
            return employee1.Id == employee2.Id;
        }

        // This overloads the != operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // This will return the opposite result of the == operator
            return !(employee1 == employee2);
        }

        // This override Equals() in order to match operator logic
        public override bool Equals(object obj)
        {
            // Checks if the object is an Employee, and then compares by Id
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }

            // If They are not an employee, this will return false
            return false;
        }

        // This is to override GetHashCode() when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

