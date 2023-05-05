using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Aud_Semestr_2
{
    abstract class Base
    {
        protected string surname;
        protected string name;
        protected string otchestvo;
        protected string birthday;
        public Base(string Surname, string Name, string Otchestvo, string Birthday)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Otchestvo = Otchestvo;
            this.Birthday = Birthday;            
        }
        public  string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Birthday { get; set; }    
    }
}
