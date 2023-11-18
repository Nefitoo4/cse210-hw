using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Conditionals
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit: ");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car: ");
            int CarSpeed = Convert.ToInt32(Console.ReadLine());
            int DemeritPoints = (CarSpeed - SpeedLimit) / 5;

            if (CarSpeed < SpeedLimit)
            {
                Console.WriteLine("Ok.");
            }
            else if (DemeritPoints > 12)
            {
                Console.WriteLine($"{DemeritPoints} Demerit Points - License Suspended.");
            }
            else
            {
                Console.WriteLine($"{DemeritPoints} Demerit points.");
            }
        }
    }
}