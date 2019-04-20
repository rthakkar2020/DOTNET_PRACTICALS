using System;
namespace practical2
{
    class P1
    {
    static void Main(string[] args)
        {
            for(int i=5;i>0;i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
