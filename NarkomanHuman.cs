using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASLEDOVANIE_OOP
{
    class NarkomanHuman : BumHuman // он перёд всё у бомжа (отбирает кровное)
    {
        public void ActivituNarkomanHuman ()
        {
            Console.WriteLine("Наркоман~Найти клад удачи в тюряге - 100 хп");
            Status -= 8; // чооооооо минус сошиал кредит левел 
        }

        public void  A (int HealthNarkoman)
        {
            Console.WriteLine("-------------------------------");
            Health -= HealthNarkoman;
            Console.WriteLine(Health);
            ActivituNarkomanHuman();
            Console.WriteLine(Health);
            Console.WriteLine("-------------------------------");
            EntrBeep();
        }
    }
}
