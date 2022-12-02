using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LINQ_AtoZ.Model;

namespace LINQ_AtoZ
{
    public static class ConverstionOperators
    { 
        public static IEnumerable<string> GetConverstionOperators() 
        {
        string[] countries = { "Australia", "Canada", "Germany", "US", "India", "Italy", "UK", };

        IOrderedEnumerable<string> result = countries.OrderBy(x => x);
        
        var results =  from f in countries 
                        orderby f ascending
                        select f;
            // change this list to a dictionary having studendid as key and value as name 
         Dictionary<int,string> dictionaryValues =    Student.GetAllStudents().ToDictionary(x => x.ID, x => x.Name);   // this is explicitly saying give me studend id with value name 


            Dictionary<int,Student> dictionarywithStudentObj = Student.GetAllStudents().ToDictionary(x => x.ID);   // this is explicitly saying give me studend id with value name 

            foreach (KeyValuePair<int, Student> value in dictionarywithStudentObj)
            {
                Console.WriteLine("{0} key :  is my Gender : {1}", value.Key, value.Value.Gender);
               foreach (var item in value.Value.Subjects)
                {

                    Console.WriteLine("{0} is my subject and my name is {1} ", item , value.Value.Name ); 

                } 

            }

        return result;
        }

    }   
}

