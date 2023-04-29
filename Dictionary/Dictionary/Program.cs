using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,string> dict = new Dictionary<string,string>();
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
            Console.WriteLine("8 -- ToString()");
            Console.WriteLine("9 -- Equals()");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Add(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                   Clear(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                   ContainsKey(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                   ContainsValue(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Remove(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(dict.GetType());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(dict.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                  ToString(ref dict);
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                    Console.Clear();
                    Console.WriteLine(dict.Equals(dict));
                    finished = nad();
                    break;
                case ConsoleKey.D0:
                  
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
    static Dictionary<string,string> Add(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        string stop;
        do
        {
            Console.WriteLine("Введите ключи-пары словаря");
            dict.Add(Console.ReadLine(), Console.ReadLine());           
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref dict);
        return dict;
    }
    static Dictionary<string,string> Print(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        foreach(var item  in dict)
        {
            Console.WriteLine(item);
        }
        return dict;
    }
    static Dictionary<string,string> Clear(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        dict.Clear();
        return dict;
    }
    static Dictionary<string,string> ContainsKey(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        Print(ref dict);
        Console.WriteLine("Введите ключ наличие которого вы хотите проверить");
        if (dict.ContainsKey(Console.ReadLine()))
        {
            Console.WriteLine("Такой ключ есть в словаре");
        }
        else
        {
            Console.WriteLine("Такого ключа в словаре нет");
        }
        return dict;
    }
    static Dictionary<string, string> ContainsValue(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        Print(ref dict);
        Console.WriteLine("Введите значение наличие которого вы хотите проверить");
        if (dict.ContainsValue(Console.ReadLine()))
        {
            Console.WriteLine("Такое значение есть в словаре");
        }
        else
        {
            Console.WriteLine("Такого значения в словаре нет");
        }
        return dict;
    }
    static Dictionary<string,string> Remove(ref Dictionary<string,string> dict)
    {
        Console.Clear();
        Console.WriteLine("Удалить значение по ключу");
        dict.Remove(Console.ReadLine());
        Print(ref dict);
        return dict;
    }
    static void ToString(ref Dictionary<string,string> dict)
    {
        Console.Clear();      
        Console.WriteLine(dict.ToString());
    }
}