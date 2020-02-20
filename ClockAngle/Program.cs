using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente the hour : ");
            float h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minute : ");
            float m = int.Parse(Console.ReadLine());
            float angle = ((h / 12) * 360) - ((m / 60) * 360);
            float h_offset = (360 / 12) / (60 / m);
            angle = angle + h_offset;
            if (angle > 180)
                angle = 360-angle;
            Console.WriteLine("The angle is : " + angle);
            Console.ReadLine();
        }
    }
}
