using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Param
    {
        /* using out keyword public static void Main()
        {
            int empid; // declare variable without initialization
            string empname;
            OutParamExample(out empid,out empname);// calling method with out keyword

            Console.Write($"Stdent details\n{ empid}:{ empname}");// accessing out parameter value
        }

            public static void OutParamExample(out int x, out string y)
            {
                x = 100;
            y = "nj";
           
        }*/
        public static void Main()
        {
            int[] n = new int[] { };
            int total2 = sum(n);
            Console.WriteLine(total2);
        }
        public static int sum(params int[] numbers)
        {
            int sum = 1;
            int n = 4;
           for(int i = 0; i < 10; i++)  
            {
                Console.WriteLine("{0}*{1}={2}", n, numbers[i], numbers[i] *n );      }
            return sum; //return keyword can retutn only one value

        }


    }
}
