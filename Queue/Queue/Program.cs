using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
       Queue queue = new Queue();
        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Enqueue()");
            Console.WriteLine("2 -- Dequeue()");
            Console.WriteLine("3 -- Clear()");
            Console.WriteLine("4 -- Contains()");
            Console.WriteLine("5 -- Peek()");
            Console.WriteLine("");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");

            ConsoleKeyInfo rab = Console.ReadKey(true);

            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Enqueue(ref queue);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                   Dequeue(ref queue);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Clear(ref queue);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Contains(ref queue);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Peek(ref queue);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(queue.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(queue.GetType());
                    finished = nad();
                    break;                 
                    case ConsoleKey.D8:
                        Console.Clear();
                    Console.WriteLine(queue.ToString());
                    finished = nad();
                    break;
                    case ConsoleKey.D9:
                        Console.Clear();
                    Console.WriteLine(queue.Equals(queue));
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
    static Queue Enqueue(ref Queue queue)
    {
        Console.Clear();
        Console.WriteLine("Добавляет объект в конец коллекции");
        string stop;
        do
        {
            Console.WriteLine("Введите элемент колллекции");
            queue.Enqueue(Console.ReadLine());            
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref queue);
        return queue;
    }
    static Queue Print (ref Queue queue)
    {
        Console.Clear();
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        return queue;
    }
    static Queue Dequeue (ref Queue queue)
    {
        Console.Clear();
        Print(ref queue);
        Console.WriteLine("Удаляет объект из начала очереди и возвращает его.");
        Console.WriteLine(queue.Dequeue());       
        return queue;
    }
    static Queue Clear(ref Queue queue)
    {
        Console.Clear();
        queue.Clear();
        Print(ref queue);
        return queue;
    }
    static Queue Contains(ref Queue queue)
    {
        Console.Clear();
       
        if (queue.Count == 0)
        {
            Enqueue(ref queue);
        }
        Print(ref queue);
        Console.WriteLine("Определяет, входит ли элемент в коллекцию");
        Console.WriteLine("Введите элемент, наличие которого хотите проверить");
        if (queue.Contains(Console.ReadLine()))
        {
            Console.WriteLine("Этот элемент есть в коллекции");
        }
        else
        {
            Console.WriteLine("Этого элемента в коллекции нет");
        }  
        return queue;
    }
    static Queue Peek(ref Queue queue)
    {
        Console.Clear();
        Print(ref queue);
        Console.WriteLine("Возвращает объект, находящийся в начале очереди Queue<T>, но не удаляет его");
        var a = queue.Peek();
        Console.WriteLine(a);               
        return queue;
    }
}