using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public static class PartitionOperators
    {
       public static void SkipTake()
        {
            string[] countries = {  "Australia", "Canada", "Germany", "US", "India" , "Italy", "UK", };

           //IEnumerable<string> result = countries.Skip(3); // returns all items after its skips the 3 

            //IEnumerable<string> result = countries.TakeWhile(x=>x.Length>2);  //takes till the condition is true 

            IEnumerable<string> result = countries.SkipWhile(x=>x.Length>2);  //skip until the condition is true when condition is false from that point onwards it will give you the value here "US" and all after it 

            foreach (var country in result)
            {
                Console.WriteLine(country);

            }

        }


    }
}
