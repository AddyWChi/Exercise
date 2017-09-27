using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyMinutes.ConsoleApp
{
    class RunMain_DetectCircularLinkList
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(n1, 2);
            Node<int> n3 = new Node<int>(n2, 3)
            {
                Next = n1
            };

            DetectCircularLinkList detect = new DetectCircularLinkList();
            Console.WriteLine("Is circular (true) : " + detect.IsCircular(n1));

            n3.Next = null;
            Console.WriteLine("Is circular (false) : " + detect.IsCircular(n1));

            return;
        }
    }

    public class DetectCircularLinkList
    {
        public DetectCircularLinkList()
        {
            return;
        }

        public bool IsCircular(Node<int> node)
        {
            if (node == null)
            {
                return false;
            }

            Node<int> slowMove = node;
            Node<int> fastMove = node;
            bool isCircular = false;
            while (slowMove.Next != null && fastMove.Next != null && fastMove.Next.Next != null)
            {
                fastMove = fastMove.Next.Next;
                slowMove = slowMove.Next;
                if (slowMove == fastMove)
                {
                    isCircular = true;
                    break;
                }
            }

            return isCircular;
        }
    }

    public class Node<T>
    {
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

        public Node<T> Next { get; set; }
        public T Val { get; set; }
    }
}
