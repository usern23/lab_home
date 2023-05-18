internal class Program
{
    private static void Main(string[] args)
    {
        int[] mass = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        var plus_m = from i in mass where i > 0 select i;
        Console.WriteLine("Положительные");
        foreach (var i in plus_m) { Console.WriteLine(i); }
        var minus_summ = (from i in mass where i < 0 select i).Sum();
        Console.WriteLine("Сумма отрицательных {0}", minus_summ);
        var count = (from i in mass where i % 5 == 0 select i).Count();
        Console.WriteLine("Количество чисел кратных 5 {0}", count);
        Console.WriteLine("Массив после обработки запросов ");
        foreach (var i in mass) Console.WriteLine(i); 
        Console.WriteLine("Удаление всех четных элементов");
        for(int  i = 0; i < mass.Length; i++) 
        {
            if (mass[i] % 2 == 0)
            {
                mass[i] = default;
            }
        }
        foreach (var i in mass) Console.WriteLine(i);       
        var plus_m1 = from i in mass where i > 0 select i;
        Console.WriteLine("Положительные");
        foreach (var i in plus_m) { Console.WriteLine(i); }
        var minus_summ1 = (from i in mass where i < 0 select i).Sum();
        Console.WriteLine("Сумма отрицательных {0}", minus_summ1);
        var count1 = (from i in mass where i % 5 == 0 select i).Count();
        Console.WriteLine("Количество чисел кратных 5 {0}", count1);

    }
}