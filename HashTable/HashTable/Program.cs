using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable hash = new Hashtable();
        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Заполнение -- Add()");
            Console.WriteLine("2 -- Очистка -- Clear()");
            Console.WriteLine("3 -- ContainsKey()");
            Console.WriteLine("4 -- ContainsValue()");
            Console.WriteLine("5 -- Remove()");
            Console.WriteLine("6 -- GetType()");
            Console.WriteLine("7 -- GetHashCode()");
            Console.WriteLine("8 -- Equals()");
            Console.WriteLine("9 -- ToString()");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Add(ref hash);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Clear(ref hash);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    ContainsKey(ref hash);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    ContainsValue (ref hash);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                   Remove(ref hash);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(hash.GetType());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(hash.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Console.WriteLine(hash.Equals(hash));
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                    Console.WriteLine(hash.ToString());
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
    static Hashtable Add(ref Hashtable hash) 
    {
        Console.Clear();
        string stop;
        do
        {
            Console.WriteLine("Введите элементы");
            hash.Add(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref hash);
        return hash;
    }
    static void Print(ref Hashtable hash)
    {
        Console.Clear();
        foreach (var item in hash)
        {
            Console.WriteLine(item);
        }
        
    }
    static void Clear(ref Hashtable hash)
    {
        Console.Clear();
        hash.Clear();
        Console.WriteLine("Теперь пусто");
        Print(ref hash);
    }
    static void ContainsKey(ref Hashtable hash)
    {
        Console.Clear();
        Console.WriteLine("Введите что-нибудь чтобы проверить, есть ли такой ключ в таблице. true - есть, false - нет");
        Console.WriteLine(hash.ContainsKey(Console.ReadLine()));
    }
    static void ContainsValue(ref Hashtable hash)
    {
        Console.Clear();
        Console.WriteLine("Введите что-нибудь чтобы проверить, есть ли такое значение в таблице. true - есть, false - нет");
        Console.WriteLine(hash.ContainsValue(Console.ReadLine()));
    }
    static void Remove(ref Hashtable hash)
    {
        Console.Clear();
        Console.WriteLine("Удаляет элемент с указанным ключом из Hashtable.");
        Console.WriteLine("Укажите ключ");
        string f = Console.ReadLine();
        hash.Remove(f);
        Print(ref hash);
    }

}
