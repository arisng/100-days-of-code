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
            using (var file = new StreamReader(@"F:\My Work Space\Github\100-days-of-code\dotnet\Challenges\TestCases\SparseArray\SparseArray3.txt"))
            {
                int stringsCount = Convert.ToInt32(file.ReadLine());

                string[] strings = new string[stringsCount];

                for (int i = 0; i < stringsCount; i++)
                {
                    string stringsItem = file.ReadLine();
                    strings[i] = stringsItem;
                }

                int queriesCount = Convert.ToInt32(file.ReadLine());

                string[] queries = new string[queriesCount];

                for (int i = 0; i < queriesCount; i++)
                {
                    string queriesItem = file.ReadLine();
                    queries[i] = queriesItem;
                }

                int[] res = SparseArraySolution.MatchingStrings(strings, queries);
                Console.WriteLine(string.Join("\n", res));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
