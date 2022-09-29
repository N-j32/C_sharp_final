using System;


namespace C_sharp_final
{
    internal class Clby
    {
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        public void Show1(ref int vall)
        {
            vall *= vall; // Manipulating value  
            Console.WriteLine("Value inside the show function " + vall);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Clby program = new Clby(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
            int vall = 50;
            Clby program1 = new Clby(); // Creating Object  
            Console.WriteLine("Value before calling the function " + vall);
            program1.Show1(ref vall); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + vall);
        }
    }
}