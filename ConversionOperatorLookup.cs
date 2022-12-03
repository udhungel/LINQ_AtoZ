using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_AtoZ.Model;

namespace LINQ_AtoZ
{
    public class ConversionOperatorLookup
    {
        public static void GetLookup()
        {

            //like dictionary its a key value pair lookup but can have same key 
            var employeeJobTitle = Student.GetAllStudents().ToLookup(x => x.City);

            Console.WriteLine("Employee Group by job title");
            foreach (var keyValue in employeeJobTitle)
            {

                Console.WriteLine(keyValue.Key);
                foreach (var emp in employeeJobTitle[keyValue.Key])
                {
                    Console.WriteLine("\t" + emp.Name + "\t" + emp.JobTitle + "\t" + emp.City);

                }


            }
            
        }

    }
}
