internal class Program
{
    private static void Main(string[] args)
    {
        bool finished = false;
        Stack<string> stack = new Stack<string>();
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Push");
            Console.WriteLine("2 -- Clear()");
            Console.WriteLine("3 -- Contains()");           
            Console.WriteLine("4 -- Pop()");
            Console.WriteLine("5 -- Peek()");
            Console.WriteLine("6 -- GetHashCode()");
            Console.WriteLine("7 -- GetType()");
            Console.WriteLine("8 -- ToString()");
            Console.WriteLine("9 -- Equals()");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");

            ConsoleKeyInfo rab = Console.ReadKey(true);

            switch (rab.Key)
            {
                case ConsoleKey.D1:                    
                    Push(ref stack);                
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Clear(ref stack);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Contains(ref stack);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Pop(ref stack);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Peek(ref stack);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(stack.GetHashCode());
                    finished = nad();
                    break;                  
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(stack.GetType());
                    finished = nad();
                    break;
                    case ConsoleKey.D8:
                    Console.Clear();
                    stack.ToString();
                    finished = nad();
                    break;
                    case ConsoleKey.D9:
                    Console.Clear();
                    Console.WriteLine(stack.Equals(stack));
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
    static Stack<string> Push(ref Stack<string> stack)
    {
        Console.Clear();
        Console.WriteLine("Заполняем стек");
        string stop;
        do
        {
            Console.WriteLine("Введите элемент стека");
            stack.Push(Console.ReadLine());
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref stack);
        return stack;
    }
    static Stack<string> Print(ref Stack<string> stack)
    {
        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }
        return stack;
    }
    static Stack<string> Contains(ref Stack<string> stack)
    {
        Console.Clear();
        Console.WriteLine("Метод Contains() проверяет наличие элемента в стеке и возвращает true если он есть");
        Console.WriteLine("Введите элемент который хотите проверить");
        string input = Console.ReadLine();
        if (stack.Contains(input))
        {
            Console.WriteLine("Этот элемент есть в стеке");
        }
        else
        {
            Console.WriteLine("Этого элемента в стеке нет");
        }
        Print(ref stack);
        return stack;
    }
    static Stack<string> Pop(ref Stack<string> stack)
    {
        Console.Clear();
        Console.WriteLine("Метод Pop() извлекает и возвращает первый элемент стека");
        Console.WriteLine(stack.Pop());
        Console.WriteLine("Теперь стек выглядит так");
        Print(ref stack);
        return stack;       
    }
    static Stack<string> Clear(ref Stack<string> stack)
    {
        Console.Clear();
        Console.WriteLine("Метод Clear() очищает стек");
        stack.Clear();
        if(stack.Count == 0)
        {
            Console.WriteLine("Стек пуст");
        }
        return stack;
    }
    static Stack<string> Peek(ref Stack<string> stack)
    {
        Console.Clear();
        Console.WriteLine("Метод Peek() просто возвращает первый элемент стека без его удаления");
        Console.WriteLine(stack.Peek());
        Console.WriteLine("Текущий стек");
        Print(ref stack);
        return stack;
    }
}
