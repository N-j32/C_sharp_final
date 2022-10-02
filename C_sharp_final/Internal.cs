using System;


namespace C_sharp_final
{
    internal class Internal
    {

        internal static int intM = 0;
    }
    public class TestAccess
    {
        static void Main()
        {
            Internal myBase = new Internal();   // Ok.
           Internal.intM = 444;    // CS0117
        }
    }


}
