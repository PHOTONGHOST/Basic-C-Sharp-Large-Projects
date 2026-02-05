using System.Data.Entity;

namespace StudentCodeFirst
{
    public class StudentContext : DbContext
    {
        // Of important not that this name must match the connection string name in App.config
        public StudentContext() : base("StudentContext") { }

        public DbSet<Student> Students { get; set; }
    }
}
