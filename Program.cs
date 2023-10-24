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

            Ob_human.C(20); // hp + 20
            Ob_humanBum.B(20); // hp - 20
            Ob_narkomanHuman.A(80); // hp - 80 
        }
    }



}