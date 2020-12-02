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
        private List<T> lst { get; set; } = new List<T>();        
        private T item { get; set; } = default(T);
        public MyStack(int indexStack, List<T> lst)
        {
            this.topIndex = -1;
            this.lst = new List<T>();
        }
        public MyStack()
        {

        }

        public void Push(T valueStack)
        {
            //lst[topIndex] = valueStack;          
            lst.Add(valueStack);
            topIndex++;
        }
        public T Pop()
        {
            T item = lst[topIndex];
            lst.RemoveAt(topIndex);
            topIndex--;
            return item;
        }

        public T Get()
        {
            return lst[topIndex];
        }
       
        public bool IsEmpty()
        {
            return lst.Count == 0;
        }
        public int Count()
        {
            return lst.Count();
        }

    }
}
