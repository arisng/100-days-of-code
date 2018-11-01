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
using dotnet.Challenges;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var file = new StreamReader(@"D:\Devl\Side Projects\100-days-of-code\HackerRank.Challenges\Challenges\TestCases\ArrayManipulation\ArrayManipulationTestCase1.txt"))
            {
                string[] nm = file.ReadLine().Split(' ');

                int n = Convert.ToInt32(nm[0]);

                int m = Convert.ToInt32(nm[1]);

                int[][] queries = new int[m][];

                for (int i = 0; i < m; i++)
                {
                    queries[i] = Array.ConvertAll(file.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
                }

                long res = ArrayManipulationSolution.ArrayManipulation(n, queries);

                Console.WriteLine(string.Join("\n", res));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
