using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Animal
    {
        public string Name { get; set; }

        public string Speech { get; set; }
        
        public Animal()
        {
            Speech = "....";
        }
        
        public virtual void Voice()
        {
            Console.WriteLine(Name + " is saying " + Speech);
        }
    }
}
