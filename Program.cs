using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int m = int.Parse(Console.ReadLine());
            int[] mass = new int[m];
            for(int i = 0; i < m; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            int v = (from int a in mass where a > 0 select a).Sum();
            int z = (from int b in mass where b < 0 select b).Count();
            int w = (from int c in mass where c % 2 == 0 select c).Aggregate((x, y) => x * y);
            Console.WriteLine("Сумма положительных элементов {0}", v);
            Console.WriteLine("Количество отрицательных элементов {0}", z);
            Console.WriteLine("Произведение четных {0}", w);
            Console.ReadKey();
        }
    }
}
