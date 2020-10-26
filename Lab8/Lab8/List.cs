using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public class LinkedList<T> where T : IComparable
    {
        private Item<T> head;
        private Item<T> tail;
        private int count;
        public class Owner
        {
            public int ID;
            public string name;
            public string organisation;
            public Owner()
            {
                ID = 0;
                name = null;
                organisation = null;
            }
        }
        public class Date
        {
            public DateTime date = DateTime.Now;
            public Date()
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public Item<T> First
        {
            get
            {
                return head;
            }
        }
        public LinkedList()
        {
        }
        public void AddAfter(Item<T> node, T value)
        {
            Item<T> newNode = new Item<T>(value, node.Next);
            node.Next = newNode;
            count++;
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = tail = new Item<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
            }
        }
        public void Delete(T value)
        {
            if (head != null)
            {
                if (head.Value.Equals(value)) {
                    head = head.Next;
                    count--;
                    return;
                }
            }
            var current = head.Next;
            var previous = head;
            while(current!= null)
            {
                if (current.Value.Equals(value))
                {
                    previous.Next = current.Next;
                    count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        public Item<T> Find(T value)
        {
            Item<T> ptr = head;
            while (ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                    return ptr;
                ptr = ptr.Next;
            }
            return null;
        }
        public static LinkedList<T> operator !(LinkedList<T> LinkedList) //перегурзка инверсии
        {
            var node = LinkedList.First;
            bool i = true;
            var str1 = node.Value;
            var str2 = node.Value;
            while (node != null)
            {
                if (i)
                {
                    str1 = node.Value;
                    i = false;
                }
                if (node.Next == null)
                {
                    str2 = node.Value;
                    node.Value = str1;
                    node = LinkedList.First;
                    node.Value = str2;
                    break;
                }
                node = node.Next;
            }
            return LinkedList;
        }
        public static LinkedList<T> operator +(LinkedList<T> list1, LinkedList<T> list2) //перегрузка сложения 
        {
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null)
            {
                node1 = node1.Next;
                if (node1.Next == null)
                {
                    node1.Next = node2;
                    break;
                }
            }
            return list1;
        }
        public static bool operator ==(LinkedList<T> list1, LinkedList<T> list2) //перегрузка на равность
        {
            bool check = false;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = true;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
        public static bool operator !=(LinkedList<T> list1, LinkedList<T> list2) //Перегрузка на неравность
        {
            bool check = true;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = false;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
    }
    public static class StatisticOperation ////////////////////////статический класс с 3мя фциями(пока что)
    {
        public static int Counter(LinkedList<string> LinkedList)
        {
            int count = 0;
            var node = LinkedList.First;
            while (node != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }
        public static int SumAll(LinkedList<int> LinkedList)
        {
            int summ = 0;
            var node = LinkedList.First;
            while (node != null)
            {
                summ = summ + node.Value;
                node = node.Next;
            }
            return summ;
        }
        public static int MaxElem(LinkedList<int> LinkedList)
        {
            int max = 0;
            var node = LinkedList.First;
            int min = node.Value;
            while (node != null)
            {
                if (max < node.Value)
                {
                    max = node.Value;
                }
                if (min > node.Value)
                {
                    min = node.Value;
                }

                node = node.Next;
            }
            max = max - min;
            return max;
        }
        public static string String___(this string str, int c) ///усечение строки
        {
            str = str.Substring(0, str.Length - c);
            return str;
        }
        public static char Last_num_in_string(string str1)
        {
            char g = ' ';
            int i = 0;
            while (i + 1 <= str1.Length)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str1[i].ToString() == j.ToString())
                    {
                        g = str1[i];
                    }
                }
                i++;
            }
            return g;
        }
    }
}
