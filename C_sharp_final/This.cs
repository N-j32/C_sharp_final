using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class This
    {
        public int id;
        public String name;
        public float salary;
        //constructor and class name should be same
        public This(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            This e1 = new This(101, "Sonoo", 890000f);
            This e2 = new This(102, "Mahesh", 490000f);
            e1.display();
            e2.display();

        }
    }
}
