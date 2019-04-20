using System;
class P2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
