using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Lab8
{
    class CollectionType<T> : IInterfaces<T> where T : class
    {
        private List<T> collection;
        public CollectionType()
        {
            collection = new List<T>();
        }
        public void Add(T element)
        {
            collection.Add(element);     
        }

        public void Remove(T element)
        {
            collection.Remove(element);
        }

        public List<T> View() => collection;
        private static string path = @"F:\file.txt";
        public static void Reader()///////////////////////////чтение из файла
        {
            StreamReader reader = new StreamReader(path);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
        public static void Writer(T element)/////////////////////////запись в файл
        {
            StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default);
            object obj = element as LinkedList<int>;
            if (obj != null)
            {
                LinkedList<int> list = (LinkedList<int>)obj;
                var node = list.First;
                while (node != null)
                {
                    writer.Write(node.Value + "->");
                    node = node.Next;
                };
                writer.Write("\n");
            }
            else
                writer.WriteLine(element);
            writer.Close();
        }
        public void EmptyOrVoid7()
        {
            if (collection.Count == 0)
                throw new Exception("Нет элементов!");
            foreach (T elem in collection)
                Console.WriteLine(elem);
        }
    }
}
