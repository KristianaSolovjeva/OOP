using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Bob");

            var duck = new Duck("Donald");


            dog.Run();
            dog.Voice();
            Console.WriteLine("");

            duck.Fly();
            duck.Voice();

            Console.ReadLine();

        }

    }
}
