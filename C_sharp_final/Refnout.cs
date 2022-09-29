using System;
namespace C_sharp_final
{
    internal class Refnout
    {
        public static void add(ref int y)
        {
            //no need to declare value y
            
        }
        public static int add1(out int y)
        {//must declare value for y
            y = 19;
            return y;
        }

        public static void Main()
            
        {
            int b = 10;
            add(ref b);
            Console.WriteLine(b);
            int c = 100;
            
            add1(out c);
            Console.WriteLine(c);

            
        }
    }
}
