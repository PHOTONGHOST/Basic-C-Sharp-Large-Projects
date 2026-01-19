using System;

namespace PolymorphismAssignment
{
    // This interface defines a contract for any implementing class and must have a Quit method
    public interface IQuittable
    {
        // This is a method signature used for quitting
        void Quit();
    }
}

