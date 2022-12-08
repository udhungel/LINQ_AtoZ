using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AtoZ
{
    public class QueryArray
    {


        //Method 1 : Find positive values in an array 
        public static int GetPositiveArrayValues()
        {
            int SumArray = 0;
            int[] myArray = new int[] { 1, 2, 3, 5, -5, -5, -5, 5, -5 };

            var result = (from x in myArray
                          where x > 0
                          select x).ToArray();

            //find the size of positive 
            return SumArray = result.Sum();

        }

        //Method 2 : Array.Indexof

        public static int GetIndexofArrayValues()
        {
            int arrayIndex = 0;

            string[] myArray = new string[] { "melon", "coconut", "lemon" };

            arrayIndex = Array.IndexOf(myArray, "lemon");

            Console.WriteLine("Index of the Array {0}", arrayIndex);

            return arrayIndex;  // returns 2 

        }



        //Method 3 : Array.Exists 
        //checks to see if the item exists this expects a predicate 
        //predicate is a function that returns true or false 
        public static bool checkIfExisitsInArray()
        {
            bool isTrue = false;

            string[] myArray = new string[] { "melon", "coconut", "lemon" };

            isTrue = Array.Exists(myArray,x=>x.Contains("x"));

            Console.WriteLine("Index of the Array {0}", isTrue);

            return isTrue;  // returns 2 

        }

        //Method 4 : Array.Find 
       
        public static string findIfExisitsInArray()
        {
            string valueFound = "";

            string[] myArray = new string[] { "melon", "coconut", "lemon" };

            valueFound = Array.Find(myArray, x => x.Contains("l")); //gets the first value it finds her

            valueFound = Array.FindLast(myArray, x => x.Contains("l")); //gets the first value from last here "lemon"

            Console.WriteLine("Found value in Array {0}", valueFound);

            //Findall 
            int sum = 0;
            int[] myPositiveNegeativeArray = new int[] { 0 - 1, -1, 2, 3, 5 };
            var resultArray = Array.FindAll(myPositiveNegeativeArray, x => x > 0);
            foreach (var item in resultArray)
            {
                sum += item;

            }
            Console.WriteLine("Positive value in Array {0}", sum);
            

            return valueFound;  // returns 2 

        }

        //Method 5 Array.Reverse 
        public static bool reverseArray()
        {
            bool isTrue = false;

            string[] myArray = new string[] { "melon", "coconut", "lemon" };

            Array.Reverse(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine("Reverse of the Array {0}", item);

            }

           

            return isTrue;  // returns 2 

        }

        //Method 6 Array.Copy    
        public static void copyArray()
        {
            string[] myArray = new string[] { "melon", "coconut", "lemon" };

            string[] newArray = new string[myArray.Length];

            Array.Copy(myArray, newArray, myArray.Length);

            foreach (var item in newArray)
            {
                Console.WriteLine("Copy of the Array {0}", item);

            }
        }

        //Method 7 Array.Sort
        //Sorts in Asc by default 

        public static void sortArray()
        {
            string[] myArray = new string[] { "melon", "coconut", "lemon" };
            Array.Sort(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine("Sorted of the Array {0}", item);

            }
        }










    }
}
