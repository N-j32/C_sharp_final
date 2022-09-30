using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Arr
    {//passing an array element
        public static void arr1(int[]b)
        {
            foreach (int j in b)
            {
                Console.WriteLine(j);
            }

        }
        public static void multi(int[,] c)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
        //param
        public void Show(params int[] val) // Params Paramater  
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", 2, j, 2 * j);
            }
        }
        public static void Main()
        {
            int[] a = new int[5];
            int[] b = new int[5] { 1, 20, 30, 4, 5 };
            //multidimensional
            int[,] c = new int[2, 2];
            //initializa
            c[0, 0] = 1;
            c[0, 1] = 2;
            c[1, 0] = 3;
            c[1, 1] = 4;
            multi(c);


            arr1(b);
            a[0] = 10;
            a[1] = 20;
            a[4] = 30;
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            //jagged 
            int[][] jag = new int[4][];
            jag[0] = new int[3] { 10, 20, 30 };
            jag[1] = new int[3] { 20, 30, 0 };
            jag[2] = new int[2] { 20, 30 };
            jag[3] = new int[3] { 20, 30, 90 };
            for (int i = 0; i < jag.Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    System.Console.Write(jag[i][j] + " ");
                }
                System.Console.WriteLine();


            }
            //param
            Arr program = new Arr(); // Creating Object  
            program.Show(); // Passing arguments of variable length  

        }
    }
}
