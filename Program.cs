using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList<string,string> slist = new SortedList<string,string>();
            
            bool finished = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Меню ");
                Console.WriteLine("1 -- Заполнение -- Add()");
                Console.WriteLine("2 -- Очистка -- Clear()");
                Console.WriteLine("3 -- GetHashCode()");
                Console.WriteLine("4 -- Reverse()");
                Console.WriteLine("5 -- Containskey()");
                Console.WriteLine("6 -- ContainsValue()");
                Console.WriteLine("7 -- IndexOfKey()");
                Console.WriteLine("8 -- IndexOfValue()");
                Console.WriteLine("9 -- TryGetvalue()");

                Console.WriteLine(" Нажмите ESC, чтобы выйти ");
                Console.WriteLine("\n Выберите действие");
                Console.WriteLine("Выберите: ");
                ConsoleKeyInfo rab = Console.ReadKey(true);
                switch (rab.Key)
                {
                    case ConsoleKey.D1:
                        Add(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D2:
                        Clear(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine(slist.GetHashCode());
                        finished = nad();
                        break;
                    case ConsoleKey.D4:
                        Reverse(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D5:
                        ContainsKey(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D6:
                        ContainsValue(ref slist);;
                        finished = nad();
                        break;
                    case ConsoleKey.D7:
                        IndexOfKey(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D8:
                        IndexOfValue(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.D9:
                        TryGetValue(ref slist);
                        finished = nad();
                        break;
                    case ConsoleKey.Escape:
                        finished = true;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (!finished);
        }
        static bool nad()
        {
            bool finished = false;
            Console.WriteLine("Нажмите любую кнопку чтобы вернуться, чтобы вернуться  ");
            ConsoleKeyInfo re = Console.ReadKey(true);
            if (re.Key == ConsoleKey.Enter)
            {
                finished = false;
            }
            Console.Clear();
            return finished;
        }
        static SortedList<string,string> Add(ref SortedList<string,string> slist)
        {
            Console.Clear();
            string stop;
            do
            {
                Console.WriteLine("Введите элементы");
                slist.Add(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine("Продолжить?");
                stop = Console.ReadLine();
            } while (stop != "");
            Print(ref slist);
            return slist;
        }
        static void Print(ref SortedList<string,string> slist)
        {
            Console.Clear();
            foreach (var item in slist)
            {
                Console.WriteLine(item);
            }            
        }
        static SortedList<string,string> Clear(ref SortedList<string,string> slist)
        {
            Console.Clear();
            slist.Clear();
            return slist;
        }
        static SortedList<string,string> Reverse(ref SortedList<string,string> slist)
        {
            Console.Clear();
            slist.Reverse();
            Print(ref slist);
            return slist;
        }
        
        static void ContainsKey(ref SortedList<string, string> slist)
        {
            Console.Clear();
            Console.WriteLine("Введите ключ для проверки наличия");
            string n = Console.ReadLine();
            Console.WriteLine(slist.ContainsKey(n));           
        }
        static void ContainsValue(ref SortedList<string, string> slist)
        {
            Console.Clear();
            Console.WriteLine("Введите значение для проверки наличия");
            string n = Console.ReadLine();
            Console.WriteLine(slist.ContainsValue(n));
        }
        static void TryGetValue(ref SortedList<string, string> slist)
        {
            string value = "";
            Console.Clear();
            Console.WriteLine("Введите ключ значение которого хотите получить");
            string n = Console.ReadLine();
            if (slist.TryGetValue(n, out value))
            {
                Console.WriteLine("Значение {0}", value);
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
        }
        static void IndexOfKey (ref SortedList<string, string> slist)
        {
           
            Console.Clear();
            Console.WriteLine("Введите ключ индекс которого хотите получить");
            string n = Console.ReadLine();
            Console.WriteLine(slist.IndexOfKey(n));
        }
        static void IndexOfValue(ref SortedList<string, string> slist)
        {
            
            Console.Clear();
            Console.WriteLine("Введите значение индекс которого хотите получить");
            string n = Console.ReadLine();
            Console.WriteLine(slist.IndexOfValue(n));
        }
    }
}
