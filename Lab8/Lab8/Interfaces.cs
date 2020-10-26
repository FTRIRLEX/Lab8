using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    interface IInterfaces<T>
    {
        void Add(T element);
        void Remove(T element);
        List<T> View();
    }
}
