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


            //Console.Write("enter length stack :");
            //get length stack
            //int lengthStack = int.Parse(Console.ReadLine());
                     
            Console.Write("how many values do you want enter the stack  :");
            //get number value stack
            int numberValueStack = int.Parse(Console.ReadLine());
          


            for (int i = 0; i < numberValueStack; i++)
            {
                Console.Write("enter values in stack :");
                //enter value 
                string valueStack = Console.ReadLine();
                //push value 
                st.Push(valueStack);
            }
            Console.Write("Stack is full :");
            
                       
            Console.Write("Do you want push/pop?? :");
            string answer = Console.ReadLine();
            if(answer=="pop")
            {   

                Console.WriteLine("how many values do you wan pop the stack : ");

            }
            else if(answer=="push")
            {

            }








            /*if (answer == "pop")
            {   
                Console.WriteLine(st.Pop());
                Console.ReadKey();
            }
            else if(answer == "push")
            {
                Console.Write("enter values in stack :");
                string valueStack = Console.ReadLine();
                st.Push(valueStack);
            }*/






            //Console.WriteLine(st.Pop());
            //Console.WriteLine(valueStack);                                                                            


            /*Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine("pop");*/

        }
    }
}
