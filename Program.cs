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
                .AddSingleton<IGroupByMultipleKeys, GroupByMultipleKeys>()
                .AddSingleton<IElementOperators, ElementOperators>()
                .AddSingleton<IGroupJoin, GroupJoin>()
                .AddSingleton<ICrossJoin, CrossJoin>()
                .AddSingleton<ISetOperators, SetOperators>()



                .AddScoped<EmployeeDBContext, EmployeeDBContext>()
                .BuildServiceProvider();
           


            //Get the required service
            // var getService = serviceProvider.GetService<IGroupBy>();
            var getService = serviceProvider.GetService<IGroupBy>();
            var getServiceForMultipleGroupby = serviceProvider.GetService<IGroupByMultipleKeys>();
            var getServiceForElementOperators = serviceProvider.GetService<IElementOperators>();

            var getServiceForGroupJoin = serviceProvider.GetService<IGroupJoin>();

            var getServiceForCrossJoin = serviceProvider.GetService<ICrossJoin>();

            var getServiceForSetOperators = serviceProvider.GetService<ISetOperators>();



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

            //Group by Part 11 

            // getService.GetAllGroups();
            // getServiceForMultipleGroupby.GetAllMulitpleGroups();

            //Group by Multiple Keys Part 12
            //getServiceForElementOperators.GetElementsOperators();

            //GroupJoin 13 

            //Element Operators Part 13 
            //getServiceForGroupJoin.getGroupJoin();


            //Cross JOIN 
            //getServiceForCrossJoin.getCrossJoin();

            // Set Operators 
            //getServiceForSetOperators.getSetOperators();

            //QueryArray
            QueryArray.GetIndexofArrayValues();
            QueryArray.checkIfExisitsInArray();
            QueryArray.findIfExisitsInArray();
            QueryArray.reverseArray();
            QueryArray.copyArray();
            QueryArray.sortArray();
            Console.ReadLine();
        }     


    }


}
