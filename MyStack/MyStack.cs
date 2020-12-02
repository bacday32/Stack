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
        private List<T> lst { get; set; } = new List<T>();
        private T valueStack { get; set; } = default(T);
        public MyStack(int indexStack,int lengthStack, List<T> lst,T valueStack)
        {
            this.topIndex = -1;
            this.lst = new List<T>();
            this.lengthStack = lengthStack;
            this.valueStack = valueStack;
        }
        public MyStack()
        {

        }
        public bool IsEmpty()
        {
            if (topIndex < 0)
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
            if (topIndex >= lengthStack - 1)
            {
                Console.WriteLine("Stack is full");
                Console.ReadKey();
            }
            lst.Add(valueStack);
            topIndex++;
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                Console.ReadKey();
            }
            T item = lst[topIndex];
            lst.RemoveAt(topIndex);
            topIndex--;
            return item;
        }
        public T GetValue()
        {   
            if(lengthStack==0)
            {
                Console.WriteLine("Stack is empty!");
            }
            return lst[topIndex];

        }       
        
        

    }
}
