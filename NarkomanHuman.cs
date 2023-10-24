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
            Health -= 100; // смерть
            Status -= 8; // чооооооо минус сошиал кредит левел 
        }
    }
}
