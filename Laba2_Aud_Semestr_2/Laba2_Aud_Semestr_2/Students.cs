using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Aud_Semestr_2
{
    internal sealed class Students : Base
    {
        public string Group { get; set; }
        public Dictionary<string,int> Marks { get; set; } = new Dictionary<string,int>();
        public Students(string Surname, string Name, string Otchestvo, string Birthday, string Group, Dictionary<string, int> Marks) : base(Surname, Name, Otchestvo, Birthday)
        {
            this.Group = Group;
            this.Marks = Marks;
        }
        public  void show()
        {

            Console.WriteLine("{0} - Имя, {1} - группа", Name, Group );
        }
    }
}
