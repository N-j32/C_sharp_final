using System;


namespace C_sharp_final
{
    internal class Cntrlstatement
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("If conditional statement");
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
           
            if (num%2==0 )
            {
                Console.WriteLine("Even number");
            }
            //if-else
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("odd");
            }
            //if-else ladder
            Console.WriteLine("enter a number");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark > 90)
            {
                Console.WriteLine("grade is:A+");
            }
            else if(mark<=90 && mark > 70)
            {
                Console.WriteLine("Grade is:A");
            }
            else if(mark<=70 && mark > 50)
            {
                Console.WriteLine("Grade is:C");
            }
            //switch
            Console.WriteLine("Enter a number:");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }
            //for
            Console.WriteLine("Enter a number:");
            int i = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i <= 5; i++)
            {
                Console.WriteLine("For loop "+i);
            }
            //while
            Console.WriteLine("Enter a number:");
            int j = Convert.ToInt32(Console.ReadLine());
            
           while(j < 5)
            {
                Console.WriteLine("While loop" + j);
                j++;
            }
            //do-while
            int k = 1;

            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 10);
            //break
            for (int n = 1; n <= 5; n++)
            {
                if (n == 3)
                {
                    break;
                }
                Console.WriteLine(n);
            }
            //continue
            for (int n = 1; n <= 5; n++)
            {
                if (n == 3)
                {
                    continue;
                }
                Console.WriteLine(n);
            }
        }
    }
}
