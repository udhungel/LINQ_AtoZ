using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace LINQ_AtoZ.LINQ
{
    public static class SelectMany
    {

        public static void GetSelectManyData()
        {

            IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects).Distinct(); //single Ienumerable of string. flattens the inner Ienumerable which contains the list of all subjects of all students 


            foreach (var sub in subjects)
            {
                Console.WriteLine(sub);
            }

            Console.WriteLine("-------------------------Using Sql Like Query -------------------------------------");

            //here we select student from the Getall Students
            //the second query will select the subject from the student query
            IEnumerable<string> subject = from studentlist in Student.GetAllStudents()
                                          from sub in studentlist.Subjects
                                          select sub;
            foreach (var sub in subject)
            {
                Console.WriteLine(sub);
            }


            Console.WriteLine("------------------Another example to flatten alphabet into a single list--------------------------------------");
            string[] stringArray = { "ABCDEFGHIJKLMNOPQRTUVSWXYZ", "0123456789" };

            var result = stringArray.SelectMany(s => s);

            //sql like 
            IEnumerable<char> resultSQLLike = from s in stringArray
                                              from c in s
                                              select c;

            foreach (char c in result)
            {
                Console.WriteLine(c);

            }

            Console.WriteLine("-------------------------resultSQLLike-------------------------------------");

            foreach (char c in resultSQLLike)
            {
                Console.WriteLine(c);

            }

            Console.WriteLine("--------------Student with Subject -------------------------------- above example ----------------");

            var subResult = Student.GetAllStudents().SelectMany(s => s.Subjects, (student, Subject) => new { StudentName = student.Name, subjectName = Subject });

            var subResultSqlLike = from student in Student.GetAllStudents()
                                   from sub in student.Subjects
                                   select new { StudentName = student.Name, subjectName = sub };

            foreach (var sub in subResultSqlLike)
            {
                Console.WriteLine("StudentName " + sub.StudentName + "SubjectName :  " + sub.subjectName);
            }

        }
    }
}



