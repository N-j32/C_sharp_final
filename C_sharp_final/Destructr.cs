using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Destructr
    {
        public Destructr()
        {
            Console.WriteLine("constructor invoked");
        }
        //name should be same as class name
        ~Destructr(){
            Console.WriteLine("disstructor invoked");
        }
        public static void Main()
        {
            Destructr d=new Destructr();

            
        }
    }
}
