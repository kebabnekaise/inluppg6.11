using System;

namespace inluppg6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            RitaKvadrat(4, 'A');
            Console.WriteLine("\n");
            RitaKvadrat(4, 'B', 3);
        }

        static void RitaKvadrat(int bredd, char cell, int mellanrum)
        {
            for (int y = 0; y < bredd; y++)
            {
                for (int x = 0; x < bredd; x++)
                {
                    Console.Write(cell);
                    for (int mellanrumX =  0; mellanrumX < mellanrum; mellanrumX++)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();

                for (int mellanrumY = 0; mellanrumY < mellanrum; mellanrumY++)
                {
                    Console.WriteLine();
                }
            }
        }
        
        static void RitaKvadrat(int bredd, char cell)
        {
            for (int y = 0; y < bredd; y++)
            {
                for (int x = 0; x < bredd; x++)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }
        }
    }
}