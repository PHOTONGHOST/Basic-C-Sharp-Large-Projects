using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creates an Employee object
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            // Use polymorphism with the interface type, then creates an object of type IQuittable
            IQuittable quittableEmployee = employee;

            // This calls the Quit() method through the interface reference
            quittableEmployee.Quit();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

