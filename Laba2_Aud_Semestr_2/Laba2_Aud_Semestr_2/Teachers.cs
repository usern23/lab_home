using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Aud_Semestr_2
{
    internal sealed class Teachers : Base
    {
        public string Cafedra { get; set; }
        public List<string> Disciplines { get; set; }
        public List<string> Groups_t { get; set; }
        public Teachers(string Surname, string Name, string Otchestvo, string Birthday, string Cafedra, List<string> Disciplines, List<string> Groups_t) : base(Surname, Name, Otchestvo, Birthday)
        {         
            this.Cafedra = Cafedra;
            this.Disciplines = Disciplines;
            this.Groups_t = Groups_t;
        }
        public void show()
        {
            foreach(string disc in Disciplines)
            {
                Console.WriteLine(disc);
            }
        }
    }
}
