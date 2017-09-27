using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyMinutes.ConsoleApp
{
    class RunMain_MergeSortedLinkedList
    {
        static void Main(string[] args)
        {
            // Container for reseting test data
            List<Node<int>> aList = new List<Node<int>>();
            // Test data
            Node<int> a1 = new Node<int>(1);
            aList.Add(a1);
            Node<int> a2 = new Node<int>(2);
            aList.Add(a2);
            Node<int> a3 = new Node<int>(3);
            aList.Add(a3);
            Node<int> a4 = new Node<int>(4);
            aList.Add(a4);
            Node<int> a5 = new Node<int>(5);
            aList.Add(a5);
            Node<int> a6 = new Node<int>(6);
            aList.Add(a6);

            // Container for reseting test data
            List<Node<int>> bList = new List<Node<int>>();
            Node<int> b1 = new Node<int>(1);
            bList.Add(b1);
            Node<int> b2 = new Node<int>(2);
            bList.Add(b2);
            Node<int> b3 = new Node<int>(3);
            bList.Add(b3);
            Node<int> b4 = new Node<int>(4);
            bList.Add(b4);
            Node<int> b5 = new Node<int>(5);
            bList.Add(b5);
            Node<int> b6 = new Node<int>(6);
            bList.Add(b6);
            Node<int> b7 = new Node<int>(7);
            bList.Add(b7);

            MergeSortedLinkedList<int> merge = new MergeSortedLinkedList<int>();

            Console.WriteLine("--- TC #0 List with single node. --- ");
            Console.WriteLine("Expect: 2, 3");

            Node<int> tc0 = merge.Merge(a2, b3);
            while (tc0 != null)
            {
                Console.Write(tc0.Val + "-");
                tc0 = tc0.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine("--- TC #01 List with single node. --- ");
            Console.WriteLine("Expect: 2, 3");

            Node<int> tc01 = merge.Merge(b3, a2);
            while (tc01 != null)
            {
                Console.Write(tc01.Val + "-");
                tc01 = tc01.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine("--- TC #02 List with single node. --- ");
            Console.WriteLine("Expect: 2, 3, 4");

            b3.AddNext(b2);

            Node<int> tc02 = merge.Merge(a4, b3);
            while (tc02 != null)
            {
                Console.Write(tc02.Val + "-");
                tc02 = tc02.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine("--- TC #1 One of the two lists is null --- ");
            Console.WriteLine("Expect: 1, 2, 3, 4");
            a1.AddNext(a2);
            a2.AddNext(a3);
            a3.AddNext(a4);
            Node<int> tc1 = merge.Merge(a1, null);
            while (tc1 != null)
            {
                Console.Write(tc1.Val + "-");
                tc1 = tc1.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);

            Console.WriteLine("--- TC #1.1 One of the two lists is null. --- ");
            Console.WriteLine("Expect: 1, 2, 3, 4");
            a1.AddNext(a2);
            a2.AddNext(a3);
            a3.AddNext(a4);
            Node<int> tc11 = merge.Merge(null, a1);
            while (tc11 != null)
            {
                Console.Write(tc11.Val + "-");
                tc11 = tc11.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);

            Console.WriteLine("--- TC #2 One list is shorter than the other. --- ");
            Console.WriteLine("Expect: 1, 2, 3, 5, 6");
            a1.AddNext(a2);
            a2.AddNext(a3);

            b5.AddNext(b6);

            Node<int> tc2 = merge.Merge(a1, b5);
            while (tc2 != null)
            {
                Console.Write(tc2.Val + "-");
                tc2 = tc2.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine("--- TC #2.1 One list is shorter than the other. --- ");
            Console.WriteLine("Expect: 1, 2, 3, 5, 6");
            a1.AddNext(a2);
            a2.AddNext(a3);

            b5.AddNext(b6);

            Node<int> tc21 = merge.Merge(b5, a1);
            while (tc21 != null)
            {
                Console.Write(tc21.Val + "-");
                tc21 = tc21.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine(
                    "--- TC #3: One list contain values that are all greater than values in another list. --- ");
            Console.WriteLine("Expect: 1, 2, 3, 4, 5, 6, 7");
            a1.AddNext(a2);
            a2.AddNext(a3);

            b4.AddNext(b5);
            b5.AddNext(b6);
            b6.AddNext(b7);

            Node<int> tc3 = merge.Merge(b4, a1);
            while (tc3 != null)
            {
                Console.Write(tc3.Val + "-");
                tc3 = tc3.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            Console.WriteLine("--- TC #4: Two lists are of same value and same length. --- ");
            Console.WriteLine("Expect: 11, 22, 33, 44");
            a1.AddNext(a2);
            a2.AddNext(a3);
            a3.AddNext(a4);

            b1.AddNext(b2);
            b2.AddNext(b3);
            b3.AddNext(b4);

            Node<int> tc4 = merge.Merge(b1, a1);
            while (tc4 != null)
            {
                Console.Write(tc4.Val + "-");
                tc4 = tc4.Next;
            }

            Console.WriteLine();
            Node<int>.ResetNext(aList);
            Node<int>.ResetNext(bList);

            return;
        }

        /// <summary>
        /// Merge two sorted linked list
        /// </summary>
        public class MergeSortedLinkedList<T> where T : IComparable
        {
            public MergeSortedLinkedList()
            {
                return;
            }

            public Node<T> Merge(Node<T> a, Node<T> b)
            {
                // ** Prepare for traversing
                // Head of new list
                Node<T> head = null;
                // Cursor for new list, pointing to last node in the list
                Node<T> cursor = null;
                // Cursor for pointing to current node 
                Node<T> aCursor = null;
                // Cursor for pointing to current node 
                Node<T> bCursor = null;

                if (a != null && b != null)
                {
                    aCursor = a;
                    bCursor = b;
                    // a < b
                    if (a.Val.CompareTo(b.Val) < 0)
                    {
                        head = a;
                        cursor = a;
                        aCursor = a.Next;
                    }
                    else
                    {
                        head = b;
                        cursor = b;
                        bCursor = b.Next;
                    }

                    while (true)
                    {
                        if (aCursor == null || bCursor == null)
                        {
                            break;
                        }

                        // a < b
                        if (aCursor.Val.CompareTo(bCursor.Val) < 0)
                        {
                            cursor.Next = aCursor;
                            aCursor = aCursor.Next;
                        }
                        else
                        {
                            cursor.Next = bCursor;
                            bCursor = bCursor.Next;
                        }

                        cursor = cursor.Next;
                    }
                }
                else
                {
                    // If one of the list is null, set the new list to start with the other list.
                    if (a != null && b == null)
                    {
                        head = a;
                        cursor = a;
                        aCursor = a.Next;
                    }

                    if (a == null && b != null)
                    {
                        head = b;
                        cursor = b;
                        bCursor = b.Next;
                    }
                }

                //Case with one of the list is longer or the other list is null.
                while (aCursor != null)
                {
                    cursor.Next = aCursor;
                    aCursor = aCursor.Next;
                    cursor = cursor.Next;
                }

                while (bCursor != null)
                {
                    cursor.Next = bCursor;
                    bCursor = bCursor.Next;
                    cursor = cursor.Next;
                }

                return head;
            }
        }

        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Val { get; set; }

            public Node(T obj)
            {
                this.Next = null;
                this.Val = obj;

                return;
            }

            public Node(Node<T> lastNode, T obj)
                : this(obj)
            {
                if (lastNode == null)
                {
                    throw new ArgumentException("Current node is null; can not add next node.", "lastNode");
                }

                lastNode.Next = this;

                return;
            }

            public void AddNext(Node<T> n)
            {
                this.Next = n ?? throw new ArgumentNullException();

                return;
            }

            static public void ResetNext(List<Node<T>> list)
            {
                foreach (var n in list)
                {
                    n.Next = null;
                }

                return;
            }
        }
    }
}