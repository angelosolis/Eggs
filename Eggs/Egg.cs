using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    public class Egg : Tuyok
    {
        private EggType type;

        public Egg(EggType type)
        {
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("***Pagbali sa Egg***");
            Console.WriteLine("Atubangan: White and Yellow Color");
            Console.WriteLine("Luyo: Brown Color");
            Console.WriteLine("You have a " + type.ToString() + " order");
        }

        public void Tuyok()
        {
            Console.WriteLine("Tuyok sa itlog");
        }
    }
}
