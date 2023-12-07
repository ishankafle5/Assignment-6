using System;
using System.Collections.Generic;

namespace Program
{
    internal class Stack<T>

    {
        private List<T> list;

        public Stack() {
            list = new List<T>();
        }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }
        public void Push(T item)
        {
            list.Add(item);
            Console.WriteLine(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Cannot pop from an empty stack.");
            }

            T poppedItem = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Console.WriteLine($"Popped: {poppedItem}");
            return poppedItem;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Cannot peek from an empty stack.");
            }

            return list[list.Count - 1];
        }

        public void Display()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }


    }
}
