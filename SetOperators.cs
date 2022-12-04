using LINQ_AtoZ.Interface;
using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_AtoZ
{
    public class SetOperators : ISetOperators
    {

        public void getSetOperators()
        {
            List<string> mylist = new List<string> { "UK", "USA", "usa", "Canada", "UK" };

            var result = mylist.Distinct();

            var resultProjection = mylist.Distinct(StringComparer.OrdinalIgnoreCase);  // this will filter the dupe lower upper case 

            List<Student> mystudent = new List<Student>() { new Student {ID = 1 , Gender = "Male" , Name = "Mike" },
                                                            new Student {ID = 1 , Gender = "Male" , Name = "Mike" },
                                                            new Student {ID = 2 , Gender = "Female" , Name = "Ashley" }



                                                 };
            var resultDupes = mystudent.Distinct(); // Mike is printed two times 
                                               //here it compares the reference time all it does if the reference of each object , here references are different eventhough value is same.  

            var uniquerResult = mystudent.Select(x => new {ID = x.ID, Gender = x.Gender, Name =  x.Name }).Distinct(); // this is how to fiter it with reference type variables 

            foreach (var  item in uniquerResult)
            {
                Console.WriteLine(item);

            }
            
        }


    }
}
