
delegate double Maths(double x, double y, double z);
internal class Program
{
    private static void Main(string[] args)
    {
        Maths summ = (x,y,z) => x + y + z;
        Maths umnog = (x, y, z) => x * y * z;
        Maths sred = (x,y,z) => (x + y + z)/3;
        Maths maxvalue = (x, y, z) => Math.Max(Math.Max(x, y), z);
        Maths minvalue = (x,y,z) => Math.Min(Math.Min(x, y), z);
        Console.WriteLine("Ввелите элементы x | y | z");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Сумма {0}", summ(a,b,c));
        Console.WriteLine("Произведение {0}", umnog(a,b,c));
        Console.WriteLine("Среднее арифметическое {0}", sred(a,b,c));
        Console.WriteLine("Максимальное {0}", maxvalue(a,b,c));
        Console.WriteLine("Минимальное {0}", minvalue(a,b,c));
    }
}