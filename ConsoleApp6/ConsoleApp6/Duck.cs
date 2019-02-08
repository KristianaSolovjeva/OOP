using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Duck : Animal
    {
        public Duck(string name)
        {
            Name = name;
        }
        public void Fly()
        {
            Console.WriteLine(Name + " is flying");
        }

        public override void Voice()
        {
            Speech = "Quack Quack";
            base.Voice();
        }
    }
}
