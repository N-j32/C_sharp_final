using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Mthd
    {
        public void display(string empname,int empid)
        {
            Console.Write( empname);
            Console.WriteLine(":" + empid);


        }
       
        public static void Main(String[] args)
        {
            Mthd m = new Mthd();
            Mthd m1 = new Mthd();
            Mthd m2 = new Mthd();
            Mthd m3 = new Mthd();
            m.display("nj",101);
            m1.display("aj", 102);
            m2.display("sj", 103);
            m3.display("kj", 104);
        }
    }
}
