using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the first employee object
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Sample",
                LastName = "Student"
            };

            // This instantiates the second Employee object
            Employee employee2 = new Employee()
            {
                Id = 1, 
                FirstName = "Another",
                LastName = "Person"
            };

            // This compares the two Employee objects using == 
            bool areEqual = employee1 == employee2;
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            // This compares the two Employee objects using !=
            bool areNotEqual = employee1 != employee2;
            Console.WriteLine("Are employee1 and employee2 NOT equal? " + areNotEqual);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

