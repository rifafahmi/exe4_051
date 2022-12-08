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
        static void Main(string[] args)
        {
            stacks s = new stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. exit");
                Console.WriteLine("\nEnter your choice ");
                string Input = Console.ReadLine();
                char ch = Convert.ToChar(Input == "" ? "0" : Input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nSTack empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3';
                        s.display();
                        break;

                }
        }

    }
}
