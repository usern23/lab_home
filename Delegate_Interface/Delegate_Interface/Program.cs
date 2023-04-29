using Delegate_Interface;
public delegate double Operation(double x , double y);
internal class Program 
{
    
    private static void Main(string[] args)
    {
        double x = 0, y = 0;
        Si a = new Si();
        Operation op = new Operation(a.Summ);
        Operation op1 = new Operation(a.Subtraction);
        Operation op2 = new Operation(a.Multiplication);
        Operation op3 = new Operation(a.Divide);
        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Сумма");
            Console.WriteLine("2 -- Разность");
            Console.WriteLine("3 -- Произведение");
            Console.WriteLine("4 -- Частное");           
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine(op(x,y));
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine(op1(x,y));
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine(op2(x, y));
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine(op3(x, y));
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
  
}
class Si :IMath
{
    public double Summ(double x, double y)
    {
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        return x + y;
    }
    public double Subtraction(double x, double y)
    {
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        return x - y;
    }
    public double Multiplication(double x, double y)
    {
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        return x * y;
    }
    public double Divide(double x, double y)
    {
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        return x / y;
    }
}