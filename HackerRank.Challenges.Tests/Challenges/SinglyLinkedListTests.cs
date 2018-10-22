using NUnit.Framework;
using HackerRank.Challenges;
using System.IO;
using System;

namespace HackerRank.Challenges.Tests.Challenges
{
    [TestFixture]
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList _singlyLinkedList;

        [SetUp]
        public void Setup()
        {
            _singlyLinkedList = new SinglyLinkedList();

            try
            {
                using (var file = new StreamReader(@"D:\Devl\Side Projects\100-days-of-code\HackerRank.Challenges.Tests\TestCases\SinglyLinkedListTestCase1.txt"))
                {
                    var listCount = Convert.ToInt32(file.ReadLine());

                    for (int i = 0; i < listCount; i++)
                    {
                        var listItem = Convert.ToInt32(file.ReadLine());
                        _singlyLinkedList.InsertNode(listItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        [Test]
        public void Test1()
        {
            Assert.IsFalse(false, "First Test.");
        }

        [Test]
        public void Should_Print_Elements_Successfully()
        {
            // Act
            _singlyLinkedList.PrintLinkedList();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(_singlyLinkedList.printedString), "Printed String is not empty or null");
        }
    }
}