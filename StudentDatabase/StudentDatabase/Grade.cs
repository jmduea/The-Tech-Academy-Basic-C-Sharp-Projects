using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    // Define a public class named Grade
    public class Grade
    {
        // Define public properties for the grade's ID, name, and section
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        // Define a public property for the collection of students in this grade
        public ICollection<Student> Students { get; set; }
    }
}
