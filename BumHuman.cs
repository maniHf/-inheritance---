using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASLEDOVANIE_OOP
{
    class BumHuman : Human// Бомж обычный бомж которые наследует всё у человека кроме методов
    {
        public void ActivituBumHuman()
        {
            Console.WriteLine("Бомж~Отравился помоями - 20");
            Health -= 20;
            Status -= 2;
        }

    }
}
