using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Overriding
    {
        public class Sports
        {
            public virtual void voly()
            {
                Console.WriteLine("parent class");

            }
        }
        public class Kabbadi : Sports
        {
            public override void voly()
            {
                Console.WriteLine("child class");
            }

        }
        public static void Main()
        {
            Kabbadi s = new Kabbadi();
            s.voly();
            s.voly();
        }
    }
}
