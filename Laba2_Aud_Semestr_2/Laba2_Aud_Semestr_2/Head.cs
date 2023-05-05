using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Aud_Semestr_2
{
    internal sealed class Head : Base
    {
       public string Post { get; set; }
       public List<string> Tags { get; set; } = new List<string>();
       public Head(string Surname, string Name, string Otchestvo, string Birthday, string Post, List<string> Tags) : base( Surname,  Name,  Otchestvo,  Birthday)
        {
            this.Post = Post;
            this.Tags = Tags;
        }
    }
}
