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
    public class ReverseArraySolution
    {
        // Complete the reverseArray function below.
        public static int[] ReverseArray(int[] a)
        {
            //return a.Reverse().ToArray();

            //Array.Reverse(a);
            //return a;

            var size = a.Length;
            var result = new int[size];
            for (var i = size - 1; i >= 0; i--)
            {
                var index = size - i - 1;
                result[index] = a[i];
            }

            return result;
        }

        // static void Main(string[] args)
        // {
        //     try
        //     {
        //         using (var file = new StreamReader(@"F:\My Work Space\Github\100-days-of-code\dotnet\Challenges\TestCases\ReverseArray\ReverseArray1.txt"))
        //         {
        //             int arrCount = Convert.ToInt32(file.ReadLine());
        //             int[] arr = Array.ConvertAll(file.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        //             var result = ReverseArraySolution.ReverseArray(arr);
        //             Console.WriteLine(String.Join(" ", result));
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex);
        //     }
        // }
    }
}