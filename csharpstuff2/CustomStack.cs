using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstuff2
{
    internal class CustomStack<T>
    {
        private int internalIndex = -1;
        public T[] items = new T[10];

        public void Push(T item)
        {
            internalIndex++;
            items[internalIndex] = item;
        }

        public T Pop()
        {
            T lastItem = items[internalIndex];
            internalIndex--;
            return lastItem;
        }

        public int count()
        {
            return internalIndex + 1;
        }



        //static void Main(string[] args)
        //{
            

        //    CustomStack<string> stack = new CustomStack<string>();

        //    stack.Push("Jedi");
        //    stack.Push("Skillslabd");
        //    stack.Push("Programming");
        //    stack.Push("OOP");

        //    Console.WriteLine($"Number of elements in the stack : {stack.count()}");

        //    while (stack.count() > 0)
        //    {
        //        var item = stack.Pop();
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadKey();


        //}
        
    }
}
