using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_final
{
    internal class Srruct_car
    {
        struct Car
        {
            public string car_name;
            public int car_id;
        }
        public static void Main()
        {
            Car c;
            c.car_id
= 100;            Console.WriteLine(c.car_id);


        }
    }
}
