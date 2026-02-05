using System;
using System.Data.Entity;
using System.Linq;

namespace StudentCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App started...");

            try
            {
                using (var db = new StudentContext())
                {
                    Console.WriteLine("Context created...");

                    var student = new Student { Name = "Caleb Beckwith" }; // That's my name, there are many like it but this one is mine
                    db.Students.Add(student);

                    Console.WriteLine("Saving...");
                    db.SaveChanges();

                    Console.WriteLine("Saved! Listing students:");
                    foreach (var s in db.Students.ToList())
                    {
                        Console.WriteLine($"{s.StudentId}: {s.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR:");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

