using System;
using System.Collections.Generic;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов");
        int n = int.Parse(Console.ReadLine());        
        Array arr = Array.CreateInstance(typeof(string), n);

        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Заполнение -- SetValue()");
            Console.WriteLine("2 -- Очистка -- Clear()");
            Console.WriteLine("3 -- Sort()");
            Console.WriteLine("4 -- Reverse()");
            Console.WriteLine("5 -- BinarySearch()");
            Console.WriteLine("6 -- GetType()");
            Console.WriteLine("7 -- GetHashCode()");
            Console.WriteLine("8 -- GetLength()");
            Console.WriteLine("9 -- Index()");
          
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    SetValue(ref arr);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                   Clear(ref arr); 
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                   Sort(ref arr);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Reverse(ref arr);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Binary(ref arr);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(arr.GetType());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(arr.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Console.WriteLine(arr.GetLength(0));
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                    Index(ref arr);
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
    static Array SetValue(ref Array arr)
    {
        Console.Clear();
        for (int i = 0; i < arr.Length; i++)
        {
            arr.SetValue(Console.ReadLine(), i);
        }
        Print(ref arr);
        return arr;
    }
    static Array Print(ref Array arr)
    {
        Console.Clear();
        foreach(string s in arr) Console.WriteLine(s);
        return arr;
    }
    static Array Reverse(ref Array arr)
    {
        Console.Clear();
        Array.Reverse(arr);
        Print(ref arr);
        return arr;
    }
    static Array Sort(ref Array arr)
    {
        Console.Clear();
        Array.Sort(arr);
        Print(ref arr);
        return arr;
    }
    static Array Clear(ref Array arr) 
    { 
        Console.Clear();
        Array.Clear(arr);
        return arr;
    }
    
   static void Binary(ref Array arr)
    {
        Console.Clear();
        Console.WriteLine("Введите элемент для поиска");
        string g = Console.ReadLine();
        Console.WriteLine(Array.BinarySearch(arr, g));
    }
   static void Index(ref Array arr)
    {
        Console.Clear();
        Console.WriteLine("возвратит индекс элемента поиска");
        string k = Console.ReadLine();
        Console.WriteLine(Array.IndexOf(arr, k)); 
    }
    
}
