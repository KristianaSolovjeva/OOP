using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var NormalMan = new Normal("Tom", 18, "reading");
            var SuperMan = new Super("Harry", 32, "flying");

            NormalMan.Introduction();
            Console.WriteLine();

            SuperMan.Introduction();
            Console.WriteLine();

            Console.WriteLine("Press Enter for a List: ");
            Console.ReadLine();

            List<Human> HumanList = new List<Human>();
            HumanList.Add(NormalMan);
            HumanList.Add(SuperMan);

            foreach(var person in HumanList)
            {
                person.Introduction();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
