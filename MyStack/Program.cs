using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //create MyStack type string
            MyStack<string> st = new MyStack<string>();
            while(true)
            {
                Console.WriteLine("Choose a number :");
                Console.WriteLine("1: push");
                Console.WriteLine("2: pop");
                Console.WriteLine("3: show value");
                //enter number in 1,2,3
                int number = int.Parse(Console.ReadLine());
                if(number==1)
                {
                    Console.WriteLine("Enter value stack: ");
                    //enter value stack
                    string valueStack = Console.ReadLine();
                    //add value 
                    st.Push(valueStack);
                }
                else if(number==2)
                {
                    //Console.WriteLine("you are poped a value out stack :");
                    //pop value
                    st.Pop();
                    //show value pop
                    Console.WriteLine(st.Pop());
                }
                else if(number==3)
                {       //get value current            
                        Console.WriteLine(st.GetValue());                        
                }
            }

         
        }
    }
}
