using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace dotnet.Challenges
{
    public class ArrayManipulationSolution
    {
        public static long ArrayManipulation(int n, int[][] queries)
        {
            var array = new long[n];
            long max = 0;

            for (var i = 0; i < queries.Length; i++)
            {
                var startIndex = queries[i][0] - 1;
                var endIndex = queries[i][1] - 1;
                var summand = queries[i][2];

                for (var j = startIndex; j <= endIndex; j++)
                {
                    array[j] += summand;
                    if (array[j] > max) max = array[j];
                }
            }

            return max;
        }

        // static void Main(string[] args)
        // {
        //     try
        //     {
        //         using (var file = new StreamReader(@"F:\My Work Space\Github\100-days-of-code\dotnet\Challenges\TestCases\ArrayManipulation\ArrayManipulationTestCase1.txt"))
        //         {
        //             string[] nm = file.ReadLine().Split(' ');

        //             int n = Convert.ToInt32(nm[0]);

        //             int m = Convert.ToInt32(nm[1]);

        //             int[][] queries = new int[m][];

        //             for (int i = 0; i < m; i++)
        //             {
        //                 queries[i] = Array.ConvertAll(file.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        //             }

        //             long res = ArrayManipulation(n, queries);


        //             Console.WriteLine(string.Join("\n", res));
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex);
        //     }
        // }
    }

}