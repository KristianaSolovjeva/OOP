using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class Human
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public Human()
        {
            Occupation = "human";
        }

        public virtual void Introduction()
        {
            Console.WriteLine(Name + " is a " + Occupation + ".");
            Console.WriteLine(Name + "'s " + Age + " years old and loves " + Hobby + ".");
        }
    }
}
