using NASLEDOVANIE_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManiHf
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Human Ob_human = new Human();
            BumHuman Ob_humanBum = new BumHuman();
            NarkomanHuman Ob_narkomanHuman = new NarkomanHuman();

            Ob_human.Health = 100;
            Ob_humanBum.Health = 80;
            Ob_narkomanHuman.Health = 50;

            Console.WriteLine(Ob_human.Health);
            Console.WriteLine(Ob_humanBum.Health);
            Console.WriteLine(Ob_narkomanHuman.Health);

            Ob_human.ActivituHuman();
            Ob_humanBum.ActivituBumHuman();
            Ob_narkomanHuman.ActivituNarkomanHuman();

            Console.WriteLine(Ob_human.Health);
            Console.WriteLine(Ob_humanBum.Health);
            Console.WriteLine(Ob_narkomanHuman.Health);


            Console.ReadKey();
        }

        // Поменяю и добавлю методы 

    }
}