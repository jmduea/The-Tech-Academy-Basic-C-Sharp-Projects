namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the SchoolContext class using the "using" statement
            // This ensures that the context is properly disposed of when we're done using it
            using (var context = new SchoolContext())
            {
                // Create a new Student object and set its StudentName property to "Bill"
                var stud = new Student() { StudentName = "Bill" };

                // Add the new student to the Students DbSet in the SchoolContext
                context.Students.Add(stud);

                // Save the changes to the database
                context.SaveChanges();
            }
        }
    }
}
