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
            IEnumerable<tblEmployee> emplyee= empdb.tblEmployees.Where(x => x.Gender == "Male");

            foreach (var emp in emplyee)
            {
                Console.WriteLine("Employe Name {0} ", emp.Name);

            }


            
            Console.ReadLine();
        }


    }
}
