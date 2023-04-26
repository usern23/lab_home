using System.Collections;
internal class Program

{
    private static void Main(string[] args)
    {
       
        ArrayList arrlist = new ArrayList();
       bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Заполнение -- Add()");
            Console.WriteLine("2 -- Очистка -- Clear()");
            Console.WriteLine("3 -- Contains()");
            Console.WriteLine("4 -- Sort()");
            Console.WriteLine("5 -- Insert()");
            Console.WriteLine("6 -- IndexOf()");
            Console.WriteLine("7 -- Remove()");
            Console.WriteLine("8 -- Reverse()");
            Console.WriteLine("9 -- Binary_Search()");
            Console.WriteLine("0 -- Вывести текущую коллекцию");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");

            ConsoleKeyInfo rab = Console.ReadKey(true);

            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Add(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Clear(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Contains(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Sort(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Insert(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    IndexOf(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Remove(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                    Reverse(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                   Binary_Search(ref arrlist);
                    finished = nad();
                    break;
                case ConsoleKey.D0:
                    Set_Range(ref arrlist);
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
    static ArrayList Add(ref ArrayList list) 
    {
        Console.Clear();
        string stop;
        do
        {
            Console.WriteLine("Введите элемент колллекции");
            list.Add(Console.ReadLine());
            if (list.Contains(""))
            {
                list.Remove("");
            }
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        }while(stop != "");
        Print(ref list);
        return list;
    }
    static ArrayList Print(ref ArrayList list)
    {
        Console.Clear();
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }
    static ArrayList Clear(ref ArrayList list)
    {
        Console.Clear();
        list.Clear();
        if (list.Count == 0) 
        {
            Console.WriteLine("Коллекция пуста");
        }
        Print(ref list);
        return list;
    }
    static void Contains(ref ArrayList list)
    {
        Console.Clear();
        Print(ref list);
        Console.WriteLine("Введите элемент который хотите проверить");
       var a = Console.ReadLine();
        if (list.Contains(a))
        {
            Console.WriteLine("Этот элемент есть в коллекции");
        }
        else
        {
            Console.WriteLine("Этого элемента в коллекции нет");
        }
       
    }
    static ArrayList Sort(ref ArrayList list)
    {
        Console.Clear();
        if(list.Count == 0)
        {
            Add(ref list);
        }
        list.Sort();
        Print(ref list);
        return list;
    }
    static ArrayList Insert(ref ArrayList list) 
    {
        Console.Clear();
        if (list.Count == 0)
        {
            Add(ref list);
        }
        Console.WriteLine("Введите индекс и элемент который хотите добавить");
        list.Insert(int.Parse(Console.ReadLine()), Console.ReadLine());
        Print(ref list);
        return list;
    }
    static ArrayList IndexOf(ref ArrayList list)
    {
        Console.Clear();
        if (list.Count == 0)
        {
            Add(ref list);
        }
        Console.WriteLine("Введите элемент индекс которого вы хотите получить");
        Console.WriteLine(list.IndexOf(Console.ReadLine()));
        return list;
    }
    static ArrayList Remove(ref ArrayList list)
    {
        Console.Clear();
        if (list.Count == 0)
        {
            Add(ref list);
        }
        Console.WriteLine("Выберите элемент который хотите удалить");
        list.Remove(Console.ReadLine());
        Print(ref list);
        return list;
    }
    static ArrayList Reverse(ref ArrayList list)
    {
        Console.Clear();
        if (list.Count == 0)
        {
            Add(ref list);
        }
        Console.WriteLine("Переворачивает коллекцию");
        list.Reverse();
        Print(ref list);    
        return list;
    }
    static ArrayList Binary_Search(ref  ArrayList list)
    {
        Console.Clear();
        if (list.Count == 0)
        {
            Add(ref list);
        }
        list.Sort();
        Console.WriteLine("Введите элемент для поиска");
        int x = list.BinarySearch(Console.ReadLine());
        if(x < 0)
        {
            Console.WriteLine("Не найден");
        }
        else
        {
            Console.WriteLine("Найден");
        }
        Console.WriteLine(x);
        return list;
    }
    static void Set_Range(ref ArrayList list)
    {       
        Console.Clear();
        Console.WriteLine("копирует в список элементы коллекции col, начиная с индекса index");
        if (list.Count == 0)
        {
            Add(ref list);
        }
        Stack stack = new Stack();
        stack.Push(Console.ReadLine());
        stack.Push(Console.ReadLine());
        stack.Push(Console.ReadLine());

        list.SetRange(0, stack);
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }

    }
}
