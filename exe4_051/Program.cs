using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exe4_051
{   
    class Node
    {
        public int info;
        public Node next;
        public Node(int 1, Node n)
        {
            info = r;
            next = a;
        }
    }
    class stacks
    {
        Node top;

        public stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);

        }
        public void push (int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element +" pushed. ");


        }
        public void pop()
        {
            Console.WriteLine("\nThe poped element is :" + top.info);
            top = top.next;


        }
        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {

                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);

                }
                Console.WriteLine();
            }
        }


    }
}
