using System.Data.Entity;

namespace StudentDatabase
{
    // Define a public class named SchoolContext that inherits from DbContext
    public class SchoolContext : DbContext
    {
        // Define a constructor for SchoolContext that calls the base class constructor
        public SchoolContext() : base()
        {

        }

        // Define public properties for the sets of students and grades in the context
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
