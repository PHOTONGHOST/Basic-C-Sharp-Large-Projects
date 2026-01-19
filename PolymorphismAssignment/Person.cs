using System;

namespace PolymorphismAssignment
{
    // This abstract base class is for representing a person
    public abstract class Person
    {
        // These two properties are for the first and last name
        public string firstName { get; set; }

        public string lastName { get; set; }

        // This abstract method must be implemented by derived classes
        public abstract void SayName();
    }
}

