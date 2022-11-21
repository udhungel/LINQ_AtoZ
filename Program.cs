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
            string strName = "jordy";
            string result = strName.ChangeFirstLetterCase();

            Console.WriteLine("After using Extension method , Name is  {0} ", result);


            Console.WriteLine("---------------------------xxxxx--------------------------------------xxxxxxx----------------------------- ");

            //Other example using Where which is a extension method in IEnumerable<T>
            // in order to exten you need to make static and the parameter type need to proceed with this
            List<int> listnum= new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            IEnumerable<int> numbers = Enumerable.Where(listnum, n => n % 2 == 0);
            foreach (int number in numbers) 
            {
                Console.WriteLine("Using Ienumberabl and using Where clause as extenstion while passing source {0} ", number);
            }

            Console.ReadLine();
        }

        
    }
}
