using Laba2_Aud_Semestr_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        bool finished = false;
        //Преподаватели
        List<Teachers> teacher = new List<Teachers>();
        //Управленцы
        List<Head> heads = new List<Head>();       
        //Студенты
        List<Students> students = new List<Students>();
        //Персонал
        List<Personal> personals = new List<Personal>();
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 -- Заполнение преподавателей");
            Console.WriteLine("2 -- Заполнение студентов");
            Console.WriteLine("3 -- Заполнение руководства");
            Console.WriteLine("4 -- Заполнение персонала");
            Console.WriteLine("5 -- Выборка по преподавателям");
            Console.WriteLine("6 -- Выборка по студентам");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("\n Выберите действие");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Teach(teacher);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Stud(students);         
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Head(heads);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Pers(personals);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Teacher(students,teacher); 
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Student(students,teacher);
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Tag(heads);
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
    static void Stud(List<Students> students)
    {
        Console.WriteLine("Введите количество студентов");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            {
                Helper.Add_Students(students);
            }
        }
    }
    static void Teach(List<Teachers> teach)
    {
        Console.WriteLine("Введите количество преподавателей");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            {
                Helper.Add_Teachers(teach);
            }
        }
    }
    static void Pers(List<Personal> pers)
    {
        Console.WriteLine("Введите количество работников персонала");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            {
                Helper.Add_Personal(pers);
            }
        }
    }
    static void Head(List<Head> head)
    {
        Console.WriteLine("Введите количество главных в университете");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            {
                Helper.Add_Heads(head);
            }
        }
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
    public static void Teacher(List<Students> students, List<Teachers> teachers)
    {
        Console.Clear();
        Console.WriteLine("Выборка по преподавателям");
        Console.WriteLine("Введите фамилию преподавателя");
        string surname1 = Console.ReadLine();

        foreach(Teachers teach in teachers)
        {
            if( surname1 == teach.Surname)
            {
                teach.show();
                foreach(string predm in teach.Disciplines )
                {                   
                    foreach (Students student in students)
                    {
                        if (student.Marks.ContainsKey(predm) && student.Marks.ContainsValue(2))
                        {
                            Console.WriteLine("Должник: " + student.Surname + " " + student.Name + " " + student.Otchestvo + " " + predm);                            
                            
                        }
                    }
                    
                }
            }
        }
    }
    public static void Student(List<Students> students, List<Teachers> teachers)
    {
        Console.Clear();
        Console.WriteLine("Выборка по студентам");
        Console.WriteLine("Введите фамилию студента ");
        string surname1 = Console.ReadLine();
        foreach (Students stud in students)
        {

            if (stud.Surname == surname1)
            {
                foreach (Teachers teach in teachers)
                {
                    foreach (var key1 in teach.Disciplines)
                    {
                        foreach (var (key, value) in stud.Marks)
                        {

                            if (value == 2 && teach.Groups_t.Contains(stud.Group) && key1 == key)
                            {
                                Console.WriteLine(stud.Surname);
                                Console.WriteLine(key);
                                Console.WriteLine(value);
                            }
                        }
                    }

                }
            }
        }
    }
    public static void Tag(List<Head> heads)
    {
        Console.Clear();
        Console.WriteLine("s -- Студенты");
        Console.WriteLine("t -- Преподаватели");
        Console.WriteLine("h -- Главные");
        Console.WriteLine("p -- Персонал");
        Console.WriteLine("Введите префикс");
        string tag1 = Console.ReadLine();
        foreach (Head head in heads)
        {
            foreach (string s in head.Tags)
            {
                string[] pref = s.Split(' ');
                if (pref[0] == "s" && tag1 == "s")
                {
                    Console.WriteLine(s);
                }else if (pref[0] == "t" && tag1 == "t")
                {
                    Console.WriteLine(s);
                }else if (pref[0] == "h" && tag1 == "h")
                {
                    Console.WriteLine(s);
                }else if (pref[0] == "p" && tag1 == "p")
                {
                    Console.WriteLine(s);
                }               
            }
        }
    }
}