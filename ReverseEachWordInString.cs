using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class ReverseEachWordInString
    {

        public static void getReverse()
        {
            string mySentence = "one two three four";

            string separator = " ";

            var splitArray = mySentence.Split(' ');  // split will return an array of string 

            var reverseArray = splitArray.Select(x => new String(x.Reverse().ToArray())); //returns a character array ,  here x is one item in the splitarray so here it is one , two and so on in which we reverse each item

            var result = string.Join(separator, reverseArray);
             
        }
    }

       
}
