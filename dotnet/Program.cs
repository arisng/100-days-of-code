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

public class Program {
    static void Main(string[] args)
    {
        try
        {
            using (var file = new StreamReader(@"F:\My Work Space\Github\100-days-of-code\dotnet\Challenges\TestCases\ReverseArray\ReverseArray1.txt"))
            {
                int arrCount = Convert.ToInt32(file.ReadLine());
                int[] arr = Array.ConvertAll(file.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                var result = ReverseArraySolution.ReverseArray(arr);
                Console.WriteLine(String.Join(" ", result));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
