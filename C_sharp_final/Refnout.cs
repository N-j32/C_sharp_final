using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Refnout
    {
        public static void add(ref int y)
        {
             y = 100;
            
        }

        public static void Main()
            
        {
            int b = 10;
            add(ref b);
            Console.WriteLine(b);
            // Refnout.add(ref a);
        }
    }
}
