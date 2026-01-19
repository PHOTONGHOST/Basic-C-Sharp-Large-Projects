using System;

namespace PolymorphismAssignment
{
    // Employee inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // An optional employee ID property
        public int Id { get; set; }

        // The implementation of the abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // The implementation of the Quit() method from IQuittable
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the company.");
        }
    }
}

