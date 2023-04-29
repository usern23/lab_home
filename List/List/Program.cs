internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Заполнение -- Add()");
            Console.WriteLine("2 -- Очистка -- Clear()");
            Console.WriteLine("3 -- Sort()");
            Console.WriteLine("4 -- Reverse()");
            Console.WriteLine("5 -- Insert()");
            Console.WriteLine("6 -- GetType()");
            Console.WriteLine("7 -- GetHashCode()");
            Console.WriteLine("8 -- ToString()");
            Console.WriteLine("9 -- Equals()");
            Console.WriteLine("0 -- Remove()");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                   Add(ref  list);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Clear(ref list);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Sort(ref list);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Reverse(ref list);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                   Insert(ref list);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(list.GetType());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(list.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Console.WriteLine(list.ToString());
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                    Console.Clear();
                    Console.WriteLine(list.Equals(list));
                    finished = nad();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    list.Remove(Console.ReadLine());
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
    static List<string> Add(ref List<string> list)
    {
        Console.Clear();
        string stop;
        do
        {
            Console.WriteLine("Введите элементы");
            list.Add(Console.ReadLine());
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref list);
        return list;
    }
    static List<string> Print(ref List<string> list)
    {
        Console.Clear();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }
    static List<string>  Clear(ref List<string> list)
    {
        Console.Clear();
        list.Clear();
        return list;
    }
    static List<string> Sort( ref List<string> list)
    {
        Console.Clear();
        list.Sort();
      Print(ref list);
        return list;
    }
    static List<string> Reverse(ref List<string> list)
    {
        Console.Clear();
        list.Reverse();
        Print(ref list);
        return list;
    }
    static List<string> Insert(ref List<string> list)
    {
        Console.Clear();
        list.Insert(int.Parse(Console.ReadLine()), Console.ReadLine());
        Print(ref list);
        return list;
    }

}
