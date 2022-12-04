using LINQ_AtoZ.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class GroupByMultipleKeys : IGroupByMultipleKeys
    {
        public readonly EmployeeDBContext _db;
        public GroupByMultipleKeys(EmployeeDBContext empDB) 
        {
            _db = empDB;
        }
       public void GetAllMulitpleGroups()
        {
            var result_JoinTable  = from tb1 in _db.tblEmployees
                                    join tb2 in _db.tblDepartments on tb1.departmentId equals tb2.Id
                                    select new
                                    {
                                        Name = tb1.Name,
                                        Salary = tb1.Salary,
                                        City = tb1.City,
                                        Gender = tb1.Gender,
                                        DepartmentName = tb2.Name,
                                        DepartmentId = tb2.Id
                                    };

            var result_GroupBy_Multiple = result_JoinTable.GroupBy(x=> new {x.DepartmentName , x.Gender })
                                                          .OrderBy(x=>x.Key.DepartmentName).ThenBy(x=>x.Key.Gender)
                                                          .Select(g=> new
                                                          {
                                                              Dept = g.Key.DepartmentName,
                                                              Gender = g.Key.Gender,  
                                                              Employee = g.OrderBy(x=>x.Name)
                                                          });
            foreach (var group in result_GroupBy_Multiple)
            {

                Console.WriteLine("{0} department {1} employee count = {2} ", group.Dept, group.Gender, group.Employee.Count());
                Console.WriteLine("------------------------------");
                foreach (var emp in group.Employee)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.DepartmentName + "\t" + emp.Gender);
                }
                Console.WriteLine("------------------------------");

            }


        }
            
        
    }
}
