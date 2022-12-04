using LINQ_AtoZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class ElementOperators : IElementOperators
    {
        public void GetElementsOperators()
        {
            int[] intergarsArray = new int[] {1,2,4 };

           // var resultFirst = intergarsArray.First(x => x % 2 == 0);  // sequeunce contains no matching element so will blow up 

           // var result = intergarsArray.FirstOrDefault(x => x % 2 == 0);  // give me 0 since there is not match default value for int is 0 

            //var resultElementAt = intergarsArray.ElementAt(2);  // if the index position is not there it will give indexx out of range exception

            var resultElementAtDefault  = intergarsArray.ElementAtOrDefault(3);

            //var resultSingle = intergarsArray.Single(); //if the sequence has more than one throws sequence has more than 1 item 

           // var resultSingleOrDefault  = intergarsArray.SingleOrDefault(); //very similar when sequence is empty does not throw exception but if more than 1 condition satisfies it will throw exception

            var resultDefaultIfEmpty = intergarsArray.DefaultIfEmpty(100);  // if the sequence is empty it will give you the default value for the datatype i.e 0 also has one overload to give a default value if the sequence is empty will give that value 

            

            //Console.WriteLine(resultDefaultIfEmpty);

            foreach (var item in resultDefaultIfEmpty)
            {

                Console.WriteLine(item);

            }
        }

    }
}
