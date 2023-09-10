using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        class Stack_Array
        {
            int[] data;
            int top;
            public Stack_Array(int n)
            {
                data = new int[n];
                top = 0;
            }
            public int length()
            {
                return top;
            }
            public bool isEmpty()
            {
                return top == 0;
            }
            public bool isFull()
            {
                return top == data.Length;
            }
            public void push(int e)
            {
                if(isFull())
                {
                    Console.WriteLine("Stack is full");
                    return ;
                }
                else
                {
                    data[top] = e;
                    top++;
                }
                
            }
            public int pop() 
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                
                
                    int e = data[top-1];
                    top--;
                    return e;
                
                
            }
            public int Top()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                else
                {
                    return data[top-1];
                }
            }
            public void display()
            {
                for(int i = 0; i<top; i++)
                {
                    Console.WriteLine(data[i]);
                    Console.WriteLine();
                }
            }

            
        }
        static void Main(string[] args)
        {
            Stack_Array s = new Stack_Array(6);
            Console.WriteLine("Creating a stack of 6 element using Array (push())");
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.push(5);
            s.push(6);
            s.display();
            Console.WriteLine("Size --> "+ s.length());
            Console.WriteLine();
            Console.WriteLine("Removing Element using LIFO (pop()): ");
            s.pop();
            s.display();
            Console.WriteLine("Size --> " + s.length());
            Console.WriteLine();
            Console.WriteLine("Finding Top of the element (Top())");
            
            s.display();
            Console.WriteLine("Top elempent which inserted in last: " + s.Top());
            Console.WriteLine("Size --> " + s.length());

            Console.ReadLine();
            

        }
    }
}
