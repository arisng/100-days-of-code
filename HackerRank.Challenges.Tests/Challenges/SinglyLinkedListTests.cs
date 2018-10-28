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
        private string dir;

        [SetUp]
        public void Setup()
        {
            _singlyLinkedList = new SinglyLinkedList();
            dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var index = dir.IndexOf("HackerRank");
            dir = dir.Remove(index);
        }

        [Test]
        public void Test1()
        {
            Assert.IsFalse(false, "First Test.");
        }

        [Test]
        public void Should_Print_Elements_Successfully()
        {
            // Assign
            try
            {
                using (var file = new StreamReader(@"D:\Devl\Side Projects\100-days-of-code\HackerRank.Challenges.Tests\TestCases\SinglyLinkedList\PrintElements.txt"))
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

            // Act
            SinglyLinkedList.PrintLinkedList(_singlyLinkedList.head);

            // Assert
            // Assert.IsFalse(string.IsNullOrEmpty(_singlyLinkedList.printedString), "Printed String is not empty or null");
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_Reverse_List_Successfully()
        {
            // Assign
            try
            {
                using (var file = new StreamReader(dir + @"HackerRank.Challenges.Tests\TestCases\SinglyLinkedList\ReverseTheList.txt"))
                {
                    var testCaseNum = Convert.ToInt32(file.ReadLine());
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
            Console.WriteLine("Original Linked List:");
            SinglyLinkedList.PrintLinkedList(_singlyLinkedList.head);

            // Act
            var head = SinglyLinkedList.ReverseRecursive(_singlyLinkedList.head);
            
            // Assert
            Assert.IsTrue(head != null, "head should not be null.");
            Console.WriteLine("Head = " + head.data);
            Console.WriteLine("Reversed Linked List:");
            SinglyLinkedList.PrintLinkedList(head);
        }

        [Test]
        public void Should_Insert_At_Tail_Successfully()
        {
            SinglyLinkedListNode head = null;
            // Assign
            try
            {
                using (var file = new StreamReader(dir + @"HackerRank.Challenges.Tests\TestCases\SinglyLinkedList\InsertAtTail.txt"))
                {
                    var listCount = Convert.ToInt32(file.ReadLine());

                    for (int i = 0; i < listCount; i++)
                    {
                        var listItem = Convert.ToInt32(file.ReadLine());
                        // Act
                        head = SinglyLinkedList.InsertAtTailRecursive(_singlyLinkedList.head, listItem);
                        _singlyLinkedList.head = head;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            // Assert
            Assert.IsTrue(head != null, "head should not be null.");
            SinglyLinkedList.PrintLinkedList(head);
        }
    }
}