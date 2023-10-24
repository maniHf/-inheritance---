using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASLEDOVANIE_OOP 
{
    class Human // Обычный человек или офисная мыш
    {
        public int Health;
        public int Status;
        public void ActivituHuman() 
        {
            Console.WriteLine("Обычный человек~Пойти в магаз и похавать на все деньги +20хп");
            Status = 5;
        }

        public void C (int HealthHuman)
        {
            Console.WriteLine("-------------------------------");
            Health += HealthHuman;
            Console.WriteLine(Health);
            ActivituHuman();
            Console.WriteLine(Health);
            Console.WriteLine("-------------------------------");
            EntrBeep();
        }

        public void EntrBeep ()
        {
            Console.ReadKey();
            Console.Beep();
        }

    }
}
