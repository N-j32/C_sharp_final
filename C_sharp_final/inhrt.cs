using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    public class inhrt
    {
         public int employee_salary=10000;
    }
    public class incentive : inhrt
    {
        public int bnsinc = 500;
    }
    public class bonus : incentive
    {
        public int bns = 5000;
    }
    class TestInheritance
    {
        public static void Main()
        {
            bonus b = new bonus();
            Console.WriteLine(b.employee_salary);
            Console.WriteLine(b.bns);
            Console.WriteLine(b.bnsinc);

        }
    }
}
