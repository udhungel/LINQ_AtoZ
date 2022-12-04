using LINQ_AtoZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class GroupJoin : IGroupJoin
    {
        private readonly EmployeeDBContext _Empcontext;
       public GroupJoin(EmployeeDBContext db)
        { 
            _Empcontext = db;
        }


        public void getGroupJoin()
        {
            //extension method 
            var groupJoinResult = _Empcontext.tblDepartments
                                             .GroupJoin(_Empcontext.tblEmployees,
                                                        d => d.Id,
                                                        e => e.departmentId,
                                                        (department, employee) => new // project it using new keyword 
                                                        {
                                                            department = department,
                                                            employee = employee
                                                        });
            //sql like syntax 
            var sqllikeGroupJoin = from d in _Empcontext.tblDepartments
                                   join e in _Empcontext.tblEmployees
                                   on d.Id equals e.departmentId into eGroup   // to do groupjoin we use join and into keyword to project it 
                                   select new
                                   {
                                       department = d,
                                       employee = eGroup
                                   };
            foreach (var department in sqllikeGroupJoin)
            {

                Console.WriteLine(department.department.Name);
                foreach (var employee in department.employee)
                {
                    Console.WriteLine(employee.Name +"\t" + employee.Gender +  "\t" + employee.City);

                }

                Console.WriteLine();

            }


        }
    }
}
