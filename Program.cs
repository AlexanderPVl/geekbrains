using System;

// Author: Prikhodov Alexander.

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            lesson1.enquete();
            Console.WriteLine("Your bmi = " + lesson1.bmi() + "\r\n");
            Console.WriteLine("Distance = " + lesson1.euclideanDist(0,0,1,1).ToString("f2") + "\r\n");
            lesson1.swapVariables(3, 5);
            lesson1.swapVariables2(7, 8);
            lesson1.task5("Alexander", "Prikhodov", "Moscow");
        }
    }
}
