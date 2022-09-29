using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Psbyref
    {
        public static void Swap(int num1, int num2) //copy of the values a and b
                                                     //num1 = 1008 = 20 , num2 = 1012 = 10
        {
            Console.WriteLine($"Before Swap: num1:{num1},num2:{num2}");//10,20
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swap: num1:{num1},num2:{num2}");//20,10
        }
        /// <summary>
        /// Pass By ref 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Swap1(ref int num1, ref int num2) //address of x and y 
                                                             // x = 1016 = num1 , y = 1020 = num2
        {
            Console.WriteLine($"Before Swap: num1:{num1},num2:{num2}");//100,200
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swap: num1:{num1},num2:{num2}");//200,100
        }
        public static void Main()
        {
            int a = 10; // 1000 = a = 10
            int b = 20; //1004 = b = 20
            Console.WriteLine($"Before Swap: a:{a},b:{b}");// 10,20
            Swap(a, b); //10,20 
            Console.WriteLine($"After Swap: a:{a},b:{b}");// 10,20 here we are passing actuall valye of a,b hence the value will not change
            Console.WriteLine("--------------------------------------------");
            int x = 100; //x = 1016 = 100
            int y = 200; //y = 1020 = 200
            Console.WriteLine($"Before Swap: x:{x},y:{y}");// 100,200
            Swap1(ref x, ref y); //1016,1020 here we are passing the address hence the value will chnage
            Console.WriteLine($"After Swap: x:{x},y:{y}");//200 100
        }

    }
}
