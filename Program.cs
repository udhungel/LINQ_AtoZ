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
            EmployeeDBContext empdb = new EmployeeDBContext();
            IEnumerable<string> emplyee= empdb.tblEmployees.Select(x => x.Gender); // this will only select that column gender 

            var employees = empdb.tblEmployees.Select(x => new {FirstName = x.Name , Gender = x.Gender , Department = x.departmentId });  // using anonymuous type 

            foreach (var emp in emplyee)
            {
                Console.WriteLine("Employe Name : {0} ", emp);
            }

            foreach (var emp in employees)
            {
                Console.WriteLine("Employe Name :  {0} , Gender : {1} , Department :  {2}  ", emp.FirstName , emp.Gender , emp.Department);
            }

            Console.ReadLine();
        }


    }
}
