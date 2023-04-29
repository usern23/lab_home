
namespace Car_Data_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            List<Car> listCar = new List<Car>();
            do
            {
                Console.Clear();
                Console.WriteLine("Меню ");
                Console.WriteLine("1 -- Заполнение");
                Console.WriteLine("2 -- Поиск по марке");
                Console.WriteLine("3 -- Машины моложе заданного возраста");
                Console.WriteLine("4 -- Машины с одним владельцем");
                Console.WriteLine(" Нажмите ESC, чтобы выйти ");
                Console.WriteLine("\n Выберите действие");
                Console.WriteLine("Выберите: ");

                ConsoleKeyInfo rab = Console.ReadKey(true);

                switch (rab.Key)
                {
                    case ConsoleKey.D1:
                        Blanc(listCar);
                        finished = nad();
                        break;
                    case ConsoleKey.D2:
                        Find_Mark(listCar);
                        finished = nad();
                        break;
                    case ConsoleKey.D3:
                        Yung(listCar);
                        finished = nad();
                        break;
                    case ConsoleKey.D4:
                        One(listCar);
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
        static void Blanc(List<Car> listCar)
        {
            Console.Clear();
            string stop;
            do
            {
                listCar.Add(new Car());
                Console.WriteLine("Добавить машину? Да/Нет");
                stop = Console.ReadLine();
            } while (stop != "Нет");
        }
        static void Find_Mark(List<Car> listCar)
        {
            Console.Clear();
            Console.WriteLine("Введите марку для поиска");
            string find = Console.ReadLine();
            foreach (Car car in listCar)
            {
                if (car.Model == find)
                {                    
                    car.show();
                }
            }
        }
        static void Yung(List<Car> listCar)
        {
            Console.Clear();
            Console.WriteLine("Выборка машин моложе заданного возраста");
            Console.WriteLine("Введите год машин");
            int year = int.Parse(Console.ReadLine());
            foreach (Car car in listCar)
            {
                if (Convert.ToInt32(car.Year) > year)
                {
                    car.show();
                }
            }
        }
        static void One(List<Car> listCar)
        {
            Console.Clear();
            Console.WriteLine("Выборка машин с одним владельцем");
            foreach (Car car in listCar)
            {
                if (car.Owners.Count == 1)
                {
                    car.show();
                }
            }
        }
    }
   internal class Car
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public string Year { get; set; }
            public List<Owner> Owners { get; set; } = new List<Owner>();
            public Car()
            {
                Console.WriteLine("Модель машины");
                Model = Console.ReadLine();
                Console.WriteLine("Цвет машины");
                Color = Console.ReadLine();
                Console.WriteLine("Год выпуска машины");
                Year = Console.ReadLine();
                string stop;
                do
                {
                    Console.WriteLine("Данные о владельце Имя|Год покупки|Год продажи");
                    Owners.Add(new Owner { Name = Console.ReadLine(), B_year = Console.ReadLine(), S_year = Console.ReadLine() });
                    Console.WriteLine("Продолжить заполнение владельцев? Да/Нет");
                    stop = Console.ReadLine();
                } while (stop != "Нет");
            }
            public void show()
            {
                Console.WriteLine("Марка машины - {0}, Цвет - {1}, Год выпуска - {2}", Model, Color, Year);
            }
   }
       
        internal class Owner
        {
            public string Name { get; set; }
            public string B_year { get; set; }
            public string S_year { get; set; }
        }   
}