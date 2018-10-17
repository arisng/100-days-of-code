using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotnet.Challenges
{
    class DynamicArraySolution
    {
        // Complete the dynamicArray function below.
        static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var result = new List<int>();
            var seqList = new List<List<int>>(n);
            var lastAns = 0;

            for (var i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }

            for (var i = 0; i < queries.Count; i++)
            {
                var query = queries[i];
                var x = query[1];
                var y = query[2];
                var seqIndex = (x ^ lastAns) % n;

                if (query[0] == 1) 
                {
                    // query1
                    if (seqList.Count < n)
                    {
                        seqList.Add(new List<int>());
                    }
                    if (seqIndex > seqList.Count)
                    {
                        Console.WriteLine("Incorrectly calculated index = {0}", seqIndex);
                        return result;
                    }
                    seqList[seqIndex].Add(y);
                }
                else 
                {
                    // query2
                    var index = y % seqList[seqIndex].Count;
                    lastAns = seqList[seqIndex][index];
                    result.Add(lastAns);
                }
            }
            
            return result;
        }

        // static void Main(string[] args)
        // {
        //     try
        //     {
        //         var list = new List<int>();

        //         using (var file = new StreamReader(@"F:\My Work Space\Github\100-days-of-code\dotnet\TestCases\DynamicArray\DynamicArray2.txt"))
        //         {
        //             string[] nq = file.ReadLine().TrimEnd().Split(' ');

        //             int n = Convert.ToInt32(nq[0]);

        //             int q = Convert.ToInt32(nq[1]);

        //             List<List<int>> queries = new List<List<int>>();

        //             for (int i = 0; i < q; i++)
        //             {
        //                 queries.Add(file.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        //             }

        //             List<int> result = DynamicArray(n, queries);
        //             Console.WriteLine(String.Join("\n", result));
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex);
        //     }
        // }
    }
}
