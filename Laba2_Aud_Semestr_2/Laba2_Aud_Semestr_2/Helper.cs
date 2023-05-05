using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Aud_Semestr_2
{
    internal class Helper
    {
        public static List<Teachers> Add_Teachers(List<Teachers> teachers)
        {
            Console.Clear();
            Console.WriteLine("Заполнение преподаватедей");
            string stop;
            Console.WriteLine("Фамилия");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Имя");
            string name1 = Console.ReadLine();
            Console.WriteLine("Отчество");
            string otchestvo1 = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string birthday1 = Console.ReadLine();
            Console.WriteLine("Кафедра");
            string cafedra1 = Console.ReadLine();
            Console.WriteLine("Список дисциплин");
            List<string> disciplines1 = new List<string>();
            List<string> groups_t1 = new List<string>();
            do
            {
                Console.WriteLine("Дисциплина " + (disciplines1.Count + 1));
                disciplines1.Add(Console.ReadLine());
                Console.WriteLine("Продолжить? Да/Нет");
                stop = Console.ReadLine();
            } while (stop != "");
            Console.WriteLine("Список групп, у которых преподаёт ");
            string stop1;
            do
            {
                Console.WriteLine("Группа " + groups_t1.Count + 1);
                groups_t1.Add(Console.ReadLine());
                Console.WriteLine("Продолжить?");
                stop1 = Console.ReadLine();
            } while (stop1 != "");
            teachers.Add(new Teachers(surname1, name1, otchestvo1, birthday1, cafedra1, disciplines1, groups_t1));
            return teachers;
        }
        public static List<Students> Add_Students(List<Students> students)
        {
            Console.Clear();
            string stop1;
            Console.WriteLine("Заполнение студентов");
            string stop;
            Console.WriteLine("Фамилия");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Имя");
            string name1 = Console.ReadLine();
            Console.WriteLine("Отчество");
            string otchestvo1 = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string birthday1 = Console.ReadLine();
            Console.WriteLine("Группа");
            string group = Console.ReadLine();
            Dictionary<string, int> marks = new Dictionary<string, int>();  
            Console.WriteLine("Список дисциплин и оценки");
            do
            {
                Console.WriteLine("Дисциплина");
                marks.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                Console.WriteLine("Чтобы прекратить заполнение нажмите enter, чтобы продолжить нажмите любую кнопку а затем enter");
                stop1 = Console.ReadLine();
            } while (stop1 != "");
            students.Add(new Students(surname1, name1, otchestvo1, birthday1, group, marks));
            return students;
        }
        public static List<Personal> Add_Personal(List<Personal> pers)
        {
            Console.Clear();
            Console.WriteLine("Фамилия");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Имя");
            string name1 = Console.ReadLine();
            Console.WriteLine("Отчество");
            string otchestvo1 = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string birthday1 = Console.ReadLine();
            pers.Add(new Personal(surname1, name1, otchestvo1, birthday1));
            return pers;
        }
        public static List<Head> Add_Heads(List<Head> heads)
        {
            Console.Clear();
            Console.WriteLine("Заполнение руководства");
            string stop;
            Console.WriteLine("Фамилия");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Имя");
            string name1 = Console.ReadLine();
            Console.WriteLine("Отчество");
            string otchestvo1 = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string birthday1 = Console.ReadLine();
            Console.WriteLine("Должность");
            string post1 = Console.ReadLine();
            Console.WriteLine("Хотите издать приказ?");
            List<string> tags = new List<string>();
            stop = Console.ReadLine();
           do
            {
                tags.Add(Console.ReadLine());
                stop = Console.ReadLine();
            }while (stop != "");
            heads.Add(new Head(surname1, name1, otchestvo1, birthday1, post1, tags));
            return heads;
        }
        public static void Show_T(List<Teachers> teachers)
        {
            foreach (Teachers teacher in teachers)
            {
                Console.WriteLine(teacher.Cafedra);
            }
        }
        public static void Show_S(List<Students> stud)
        {
            foreach (Students st in stud)
            {
                Console.WriteLine(st.Group);
            }
        }
        public static void Show_H(List<Head> heads)
        {
            foreach (Head head in heads)
            {
                Console.WriteLine(head.Tags);
            }
        }
    }      
}
   

