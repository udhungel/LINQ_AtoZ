using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public static class OrderingOperators
    {
        public static void GetAllOrderingOperators()
        {
            //Order by --- Order by Descending // Then by -- Then by Descending- ----  can be used more than once but not orderby --------------------------------- 

            List<Student> students = Student.GetAllStudents();
            Console.WriteLine("Before Sorting ");
            foreach (Student s in students) { Console.WriteLine(s.Name);  };


            Console.WriteLine("After Sorting by Name  ");

            IOrderedEnumerable<Student> stud = Student.GetAllStudents().OrderBy(s=>s.Name);

            IOrderedEnumerable<Student> linktoSql = from student in Student.GetAllStudents() 
                                                                    orderby student.Name
                                                                    select student;
            Console.WriteLine("------------------------------------- ");
            foreach (Student s in stud)
            { 
                Console.WriteLine(s.Name);
            };

            Console.WriteLine("---------Link to SQL---------------------------- ");
            foreach (Student s in linktoSql)
            {
                Console.WriteLine(s.Name);
            };






        }





    }
}
