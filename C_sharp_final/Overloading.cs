using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Overloading
    {
        public void Test()
        {
            Console.WriteLine("1stb method");
        }
        public void Test(int t)
        {
            Console.WriteLine("2stb method");
        }
        public void Test(string s)
        {
            Console.WriteLine("3stb method");
        }
        public void Test(int t , string s)
        {
            Console.WriteLine("4stb method");
        }
        public void Test(string s, int t)
        {
            Console.WriteLine("5stb method");
        }
        public static void Main()
        {
            Overloading p = new Overloading();
            p.Test();
            p.Test(3);
            p.Test("nj");
            p.Test(3,"nj");
            p.Test("8",3);
        }
    }
}
