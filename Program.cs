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
            //Linq Aggregate Functions
            //MIN, MAX, SUM,COUNT,AVERAGE & AGGREGATE

            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //SmallestNumber
            int smallestNumber = Numbers.Min();
            int smallestEvenNumber = Numbers.Where(x => x % 2 == 0).Min(); 

            //Largest Number 
            int largestNumber = Numbers.Max();
            int largetstEvenNumber = Numbers.Where(x=>x % 2 == 0).Max();

            //Sum of all numbers 
            int sumOfAllNumbers = Numbers.Sum(x => x);
            int sumOfEvenNumbers = Numbers.Where(x=>x%2 == 0).Sum();

            //Count of all Numbers
            int countOfAllNumbers = Numbers.Count();
            int countOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Count();

            //Average of all Numbers
            double averageOfAllNumbers = Numbers.Average();
            double averageOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Average();

            
            Console.WriteLine("---------------------------xxxxx--------------------------------------xxxxxxx----------------------------- ");
            // Agregate function 
            string[] countries = { "USA","CANADA","MEXICO" };

            string result = countries.Aggregate((a, b) => a + "," + b);

            Console.WriteLine(result);

            int[] Num = { 1, 2, 3, 4, 5 };
            int resultNum = Num.Aggregate((a,b) => a * b);


            Console.WriteLine(resultNum);
            Console.ReadLine();
        }


    }
}
