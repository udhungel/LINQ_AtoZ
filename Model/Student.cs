using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string   Name { get; set; }
        public string Gender { get; set; }

        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents() 
        {
            List<Student> listStudents = new List<Student>() { new Student { ID = 1 , Name = "Joe", Gender = "Male", Subjects = new List<string>{"MVC", "JAVA", "SQL" } },
                                                               new Student { ID = 2 , Name = "Josh", Gender = "Male", Subjects = new List<string>{"JAVA", "C#", "SQL" } },
                                                               new Student { ID = 3 , Name = "Harry", Gender = "Male", Subjects = new List<string>{"JQUERY", "REACT", "SQL" } },
                                                               new Student { ID = 4 , Name = "Rose", Gender = "Female" , Subjects = new List<string>{"REACT", "C#", "SQL" }},
                                                               new Student { ID = 5 , Name = "Jasmin", Gender = "Female", Subjects = new List<string>{"JAVASCRIPT", "C++", "SQL" }},
                                                               new Student { ID = 6 , Name = "Stephanie", Gender = "Female", Subjects = new List<string>{"C++", "C#", "SQL" }}

                                                             };
            return listStudents;
        }
    }

}
