using LINQ_AtoZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{  
    public class GroupBy : IGroupBy
    {
        private readonly EmployeeDBContext _Empcontext;
        public GroupBy(EmployeeDBContext db)
        {
            _Empcontext = db;
        }
        public  void GetAllGroups()
        {
            

            var result = from t1 in _Empcontext.tblEmployees
                            join t2 in _Empcontext.tblDepartments on t1.departmentId equals t2.Id                            
                            select new {  Name = t1.Name
                                        , Salary = t1.Salary
                                        , City = t1.City
                                        , DepartmentName = t2.Name
                                        , DepartmentId = t2.Id };

            var res = from employee in result
                      group employee by employee.DepartmentName into eGroup
                      orderby eGroup.Key
                      select new
                      {
                          key = eGroup.Key,
                          Employees = eGroup.OrderBy(e => e.Name)
                      };

            foreach (var grp in res)
            {

                Console.WriteLine("{0}  -- {1} ", grp.key, grp.Employees.Count());

                Console.WriteLine("------------------------------");
                foreach (var empl in grp.Employees)
                {
                    Console.WriteLine(empl.Name + "\t" + empl.DepartmentId);

                   

                }

                Console.WriteLine();
                Console.WriteLine();
            }
    
         
        }
    }
}
