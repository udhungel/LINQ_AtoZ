using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class CrossJoin : ICrossJoin
    {
        public readonly EmployeeDBContext _emp;


        public CrossJoin(EmployeeDBContext emp) 
        {
            _emp = emp;
        }

        public void getCrossJoin()
        {
            //cross join 
            var Result = from e in _emp.tblEmployees
                            from d in _emp.tblDepartments
                            select new { e, d };
            //extension method 

            var resultextension = _emp.tblEmployees.SelectMany(e => _emp.tblDepartments,
                                                               (e, d) => new { e, d });

            var resulJointextension = _emp.tblEmployees.Join(_emp.tblDepartments
                                                             ,e => true
                                                             ,d => true 
                                                             ,( e, d) => new {e,d } );

            foreach (var item in resulJointextension)
            {

                Console.WriteLine(item.e.Name +"\t"+ item.d.Name  );   //employee name * department name 

            }
        }


    }
}
