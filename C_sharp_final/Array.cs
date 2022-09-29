using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Array
    {
        public static void Main()
        {
            //single dimention
            int[] myArr = new int[5] { 98, 76, 99, 32, 77 };
            int i, j, temp;
            Console.Write("Elements: \n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (myArr[i] < myArr[j])
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.Write("\nDescending order:\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            Console.Write("\n\n");
        }
    }
}