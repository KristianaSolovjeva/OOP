using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Normal : Human
    {
        public Normal(string name, int age, string hobby)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
        }
        
        public override void Introduction()
        {
            Occupation = "programmer";
            base.Introduction();
        }
    }
}
