using LINQ_AtoZ.LINQ;
using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_AtoZ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SelectMany logic 
            //SelectMany.GetSelectManyData();

            //Ordering Operators
            //OrderingOperators.GetAllOrderingOperators();

            //Partition operator
            //PartitionOperators.SkipTake();

            //ConverstionOperators Operator
            //ConverstionOperators.GetConverstionOperators();
            //Get Lookup Converstion operator 
            ConversionOperatorLookup.GetLookup();


            Console.ReadLine();
        }     


    }


}
