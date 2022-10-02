using System;


namespace C_sharp_final
{
    internal class AccessSpec
    {
        private void Sum()
        {
            Console.WriteLine("private class");
        }
        internal void Sum3()
        {
            Console.WriteLine("internal class");
        }
        protected void Sum1()
        {
            Console.WriteLine("protected class");
        }
        protected internal void Sum2()
        {
            Console.WriteLine("protected internal class");
        }
    public static void Main()
        {

        }
       
    }
    
}
