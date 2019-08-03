using System;
using System.Text;
using System.Threading;

namespace ProgressBar
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i <= 20; i++)
            {

                for (int y = 0; y < i; y++)
                {
                    Console.Write("x");
                }

                Console.Write(i + "/20");
                Console.SetCursorPosition(1, 1);
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
