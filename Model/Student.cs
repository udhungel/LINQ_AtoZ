using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string   Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents() 
        {
            List<Student> listStudents = new List<Student>() { new Student { ID = 1 , Name = "Joe", Gender = "Male" },
                                                               new Student { ID = 2 , Name = "Josh", Gender = "Male" },
                                                               new Student { ID = 3 , Name = "Harry", Gender = "Male" },
                                                               new Student { ID = 4 , Name = "Rose", Gender = "Female" },
                                                               new Student { ID = 5 , Name = "Jasmin", Gender = "Female"},
                                                               new Student { ID = 6 , Name = "Stephanie", Gender = "Female"}

                                                             };
            return listStudents;
        }
    }

}
