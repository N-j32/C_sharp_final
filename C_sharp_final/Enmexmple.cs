using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Enmexmple
    {
        public enum Days
        {
            Monday=1,Tuesday,Wednesday,Thursday,Friday
        }
        public static void Main()
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
                {
                Console.WriteLine(s);
            }
            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }


        }

    }
}
