using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public class Item<T>
    {
        public T Value; //значение элемента
        public Item<T> Next; //указатель на след. элемент
        public Item(T value, Item<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
