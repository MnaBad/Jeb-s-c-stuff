using System;
using System.Threading;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czy chcesz wysadzić świat?");
            Console.Write("\n");

            // Set Color
            Console.ForegroundColor = ConsoleColor.Red;
            
            // Send button
            for(int o = 4; o != 0; o--)
            {
                for(int p = 8; p != 0; p--)
                {
                    Console.Write("X");
                }
                Console.Write("\n");
            }
            
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;

            // Count
            for(int i = 1; i != 0; i--)
            {
                Console.WriteLine(i);
                Console.Beep();
                Thread.Sleep(1000);
            }
            Thread.Sleep(100);
            Console.Beep();
            Thread.Sleep(20);
            Console.Beep();
            Console.WriteLine("Świat został rozwalony, jesteś z siebie dumnny?");

            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int a = 6; a != 0; a--)
            {
                for(int s = 6; s != 0; s -= 2)
                {
                    Console.WriteLine('X');
                }
                Console.Write('\n');
            }

            Console.ReadKey();
            Console.Clear();
        }
    }

}
