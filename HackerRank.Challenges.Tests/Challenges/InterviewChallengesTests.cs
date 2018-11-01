using NUnit.Framework;
using HackerRank.Challenges;
using System.IO;
using System;
using System.Collections.Generic;
using static HackerRank.Challenges.InterviewChallenges;

namespace HackerRank.Challenges.Tests.Challenges
{
    [TestFixture]
    public class InterviewChallengesTests
    {
        private string dir;
        private InterviewChallenges _interviewChallenges;

        [SetUp]
        public void Setup()
        {
            _interviewChallenges = new InterviewChallenges();
            dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var index = dir.IndexOf("HackerRank");
            dir = dir.Remove(index);
        }

        [Test]
        public void Find_Missing_Number_Should_Return_The_Missing_Number()
        {
            // Arrange
            int[] array = null;
            var n = 0;
            try
            {
                using (var file = new StreamReader(dir + @"HackerRank.Challenges.Tests\TestCases\FindMissingNumberTestCase1.txt"))
                {
                    n = Convert.ToInt32(file.ReadLine());
                    array = Array.ConvertAll(file.ReadLine().Split(','), num => Convert.ToInt32(num));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // Act
            var missingNumber = InterviewChallenges.FindMissingNumber(n, array);
            Console.WriteLine("missingNumber = " + missingNumber);

            // Asssert
            Assert.IsTrue(missingNumber > 0, "The missing number should be greater than 0");
        }

        [Test]
        public void FindSectionsToAttend_Should_Return_Max_Number_Of_Sessions()
        {
            // Arrange
            var sessions = new List<Session>
            {
                new Session("A", new DateTime(2018, 11, 1, 8, 0, 0), new DateTime(2018, 11, 1, 9, 30, 0)), // A: 8 - 9h30
                new Session("B", new DateTime(2018, 11, 1, 8, 0, 0), new DateTime(2018, 11, 1, 10, 0, 0)), // B: 8 - 10
                new Session("C", new DateTime(2018, 11, 1, 9, 30, 0), new DateTime(2018, 11, 1, 11, 0, 0)), // C: 9 - 11
                new Session("D", new DateTime(2018, 11, 1, 11, 0, 0), new DateTime(2018, 11, 1, 12, 0, 0)), // D: 11 - 12
                new Session("E", new DateTime(2018, 11, 1, 13, 0, 0), new DateTime(2018, 11, 1, 14, 0, 0)), // E: 13 - 14
                new Session("F", new DateTime(2018, 11, 1, 10, 0, 0), new DateTime(2018, 11, 1, 11, 0, 0)), // F: 10 - 11
                new Session("G", new DateTime(2018, 11, 1, 11, 0, 0), new DateTime(2018, 11, 1, 15, 0, 0)), // G: 11 - 15
                new Session("H", new DateTime(2018, 11, 1, 15, 0, 0), new DateTime(2018, 11, 1, 17, 0, 0)), // H: 15 - 17
                new Session("I", new DateTime(2018, 11, 1, 14, 0, 0), new DateTime(2018, 11, 1, 16, 0, 0)), // I: 14 - 16
                new Session("J", new DateTime(2018, 11, 1, 15, 0, 0), new DateTime(2018, 11, 1, 16, 0, 0)), // J: 15 - 16
                new Session("K", new DateTime(2018, 11, 1, 16, 0, 0), new DateTime(2018, 11, 1, 17, 0, 0)), // K: 16 - 17
            };

            // Act
            var result = InterviewChallenges.FindSectionsToAttend(sessions);
            Console.WriteLine("Selected sessions are : " + result);

            // Assert
            Assert.IsTrue(!string.IsNullOrEmpty(result), "Result should not be empty");
        }
    }
}