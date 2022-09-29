using System;

namespace C_sharp_final
{
    internal class Fnctn

    {//function without return type
        public void Sum(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine($"{a * b}"
                );
        }
        //function with return type
        public static string name(string empname)
        {
            Console.WriteLine(empname);
            return empname;
        }

        public static void Main()
        {
            Fnctn fnctn = new Fnctn();
            
            Fnctn.name("nj");
            
           Fnctn.mul(10, 20);
            fnctn.Sum(1, 2);
        }
    }
}
