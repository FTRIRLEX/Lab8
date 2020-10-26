using Lab5;
using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //////////////////////////////////////////////////////////////////////////////////////////////////ЛАБОРАТОРНАЯ РАБОТА НОМЕР 8
                LinkedList<int> list1 = new LinkedList<int>(); //первый список 
                list1.Add(21);
                list1.Add(25);
                list1.Add(85);
                list1.Add(99);
                LinkedList<int> list2 = new LinkedList<int>(); ///второй список
                list2.Add(43);
                list2.Add(77);
                list2.Add(12);
                list2.Add(24);
                CollectionType<LinkedList<int>> collection1 = new CollectionType<LinkedList<int>>();///создание коллекции из списков
                collection1.Add(list1);
                collection1.Add(list2);
                foreach (LinkedList<int> list in collection1.View())
                    Print(list); ////////////вывод списков из коллекции
                collection1.Remove(list1);
                collection1.Remove(list2);
                collection1.EmptyOrVoid7();////проверка пустой список или нет
                CollectionType <PrimerBall> listprim = new CollectionType<PrimerBall>();///использование пользовательского типа
                PrimerBall ball1 = new PrimerBall();
                PrimerBall ball2 = new PrimerBall();
                listprim.Add(ball1);
                listprim.Add(ball2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                LinkedList<int> list3 = new LinkedList<int>();
                list3.Add(246);
                list3.Add(228);
                list3.Add(654);
                list3.Add(966);
                CollectionType<LinkedList<int>> collection2 = new CollectionType<LinkedList<int>>();
                collection2.Add(list3);
                CollectionType<LinkedList<int>>.Writer(list3);
                CollectionType<LinkedList<int>>.Reader();//чтение из файла
            }
            Console.ReadLine();
        }
        static void Print(LinkedList<int> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + "->");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
    }

