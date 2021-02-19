using System;
using System.Threading;

namespace HappyBirthday
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Grasshoper();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void Grasshoper()
        {
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.WriteLine("Grattis pa fodelsedagen Max!!!");
            Console.Beep(352, 1000);
        }
    }
}
