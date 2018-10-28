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

namespace HackerRank.Challenges
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public string printedString;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }

        // Complete the printLinkedList function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        public static void PrintLinkedList(SinglyLinkedListNode head)
        {
            var current = head;

            while (current != null)
            {
                Console.Write(string.Format("{0} {1}", current.data, current.next == null ? "\n" : "->"));
                current = current.next;
            }
        }

        public static SinglyLinkedListNode ReverseList(SinglyLinkedListNode head)
        {
            var cur = head;
            var nex = cur.next;
            var temp = nex.next;

            head.next = null;

            while (nex != null)
            {
                nex.next = cur;

                cur = nex;
                nex = temp;
                
                if (temp != null)
                {
                    temp = temp.next;
                }
            }

            return cur;
        }

        public static SinglyLinkedListNode ReverseRecursive(SinglyLinkedListNode head)
        {
            if (head == null || head.next == null) return head;

            var newHead = ReverseList(head.next);

            head.next.next = head;
            head.next = null;

            return newHead;
        }
    }

    // static void Main(string[] args) {
    //     SinglyLinkedList llist = new SinglyLinkedList();

    //     int llistCount = Convert.ToInt32(Console.ReadLine());

    //     for (int i = 0; i < llistCount; i++) {
    //         int llistItem = Convert.ToInt32(Console.ReadLine());
    //         llist.InsertNode(llistItem);
    //     }

    //     printLinkedList(llist.head);
    // }
}