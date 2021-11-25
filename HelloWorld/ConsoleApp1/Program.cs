using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int speed_limit;
            Console.WriteLine("please enter the speed limit:");
            speed_limit = int.Parse(Console.ReadLine());
            double car_speed;
            Console.WriteLine("please enter the speed of the car:");
            car_speed = Convert.ToDouble(Console.ReadLine());
            if (car_speed < speed_limit)
            {
                Console.WriteLine("OK");
            }
            else if (car_speed > speed_limit + 5*12)
            {
                Console.WriteLine("License suspended");
            }
            else
            {
                double exceeding_limit_by = car_speed - speed_limit;
                int demerit_points = (int)exceeding_limit_by / 5 + 1;
                Console.WriteLine("you will get {0} demerit points", demerit_points);
            }
        }
    }
}
