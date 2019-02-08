using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }
        public void Run()
        {
            Console.WriteLine(Name + " is running");
        }
        public override void Voice()
        {
            Speech = "Woofidy Woof Woof";
            Console.WriteLine(Name + " is saying Woof Woof");
            base.Voice();
        }
    }
}
