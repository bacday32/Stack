using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyStack<T>
    {
        private int topIndex { get; set; } = -1;
        public int lengthStack { get; set; } = 0;
        public List<T> lst { get; set; } = new List<T>();
        private T valueStack { get; set; } = default(T);    
        public MyStack()
        {
        }
        public bool IsEmpty()
        {
            if (lst.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if(lst.Count >= lengthStack-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(T valueStack)
        {
            if (IsFull())
            {
                Console.WriteLine("----->Stack is full!!!");
                Console.WriteLine("----->Press enter to continue!!");
                Console.ReadKey();
            }
            lst.Add(valueStack);
            int a = lst.Count;
            a ++;
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("----->Stack is empty!!!");
                Console.WriteLine("----->Press enter to continue!!");
                Console.ReadKey();               
            }
            
                topIndex = lst.Count;
                T item = lst[topIndex - 1];
                lst.RemoveAt(topIndex - 1);
                topIndex--;
                return item;
                                 
                                     
        }
        public T GetValue()
        {
            topIndex = lst.Count;
            if(lst.Count==0)
            {
                Console.WriteLine("Stack is empty!");
            }
            return lst[topIndex-1];            

        }
               
        
        

    }
}
