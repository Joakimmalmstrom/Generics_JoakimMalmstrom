using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics_JoakimMalmstrom
{
    internal class Box<T>
    {
        protected Stack<T> stack = new Stack<T>();

        public int Count { get { return stack.Count; } }

        public Box()
        {
        }

        public void AddToStack(T element)
        {
            stack.Push(element);
            Console.WriteLine($"{element} got pushed");
        }


        public T Remove()
        {
            return stack.Pop();
        }
    }
}