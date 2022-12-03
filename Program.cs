using LINQ_AtoZ.LINQ;
using LINQ_AtoZ.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using LINQ_AtoZ.Interface;

namespace LINQ_AtoZ
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Dependency injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGroupBy, GroupBy>() 
                .AddScoped<EmployeeDBContext, EmployeeDBContext>()
                .BuildServiceProvider();

            
            //Get the required service
            var getService = serviceProvider.GetService<IGroupBy>();



            //SelectMany logic 
            //SelectMany.GetSelectManyData();

            //Ordering Operators
            //OrderingOperators.GetAllOrderingOperators();

            //Partition operator
            //PartitionOperators.SkipTake();

            //ConverstionOperators Operator
            //ConverstionOperators.GetConverstionOperators();
            //Get Lookup Converstion operator 
            //ConversionOperatorLookup.GetLookup();

            //Group by 

            getService.GetAllGroups();

            Console.ReadLine();
        }     


    }


}
