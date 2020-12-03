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
            Console.WriteLine("-----Enter length stack-----: ");
            st.lengthStack = int.Parse(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("what do you want with stack? :");
                Console.WriteLine("1: push");
                Console.WriteLine("2: pop");
                Console.WriteLine("3: Current value");
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
                    //show value pop
                    
                    try
                    {
                        Console.WriteLine("---You are poped a value out stack--- :"+ st.Pop());                        
                    }
                    catch
                    {
                        continue;
                    }
                }
                else if(number==3)
                {       //get value current                                                         
                        Console.WriteLine("Current value ---> " + st.GetValue());                        
                }
            }
        }
    }
}
