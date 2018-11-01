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
using System.Net.Mail;

namespace HackerRank.Challenges
{
    public class InterviewChallenges
    {
        public static int FindMissingNumber(int n, int[] a)
        {
            var expectedSum = n * (n + 1) / 2;
            var actualSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                actualSum += a[i];
            }

            return expectedSum - actualSum;
        }

        public class Session
        {
            public DateTime Start {get;set;}
            public DateTime End {get;set;}
            public string Name {get;set;}

            public Session(string name, DateTime start, DateTime end)
            {
                Name = name;
                Start = start;
                End = end;
            }
        }

        public static string FindSectionsToAttend(List<Session> sessions)
        {
            var sortedSession = sessions.OrderBy(a => a.End).ToList();
            var selectedSessions = new List<Session>();

            for (var i = 0; i < sortedSession.Count; i ++)
            {
                if (i == 0) 
                { 
                    selectedSessions.Add(sortedSession[i]);
                }
                else 
                {
                    if (sortedSession[i].Start >= selectedSessions.Last().End)
                    {
                        selectedSessions.Add(sortedSession[i]);
                    }
                }
            }

            return string.Join(",", selectedSessions.Select(a => a.Name));
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