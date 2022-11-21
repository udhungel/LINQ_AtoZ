using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class Program
    {
        static void Main(string[] args)
        {
           IEnumerable<Student> stdResult =  Student.GetAllStudents().Where(s => s.Gender == "Male");
            foreach (var stud in stdResult)
            {
                Console.WriteLine("Student Name {0} amd his Id is {1} . Using lamda expression ", stud.Name, stud.ID);

            }

            Console.WriteLine("---------------------------------------------------------------------------------------------- ");

            IEnumerable<Student> queryResult = from student in Student.GetAllStudents()
                                               where student.Gender == "Male"
                                               select student ;
            foreach (var stud in stdResult)
            {
                Console.WriteLine("Student Name {0} amd his Id is {1} . Using  SQL Like query", stud.Name, stud.ID);

            }

            Console.ReadLine();
        }

        
    }
}
