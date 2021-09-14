using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          int sweet = 0;
          int salty = 0;
          int sweetnSalty = 0;
          for (int i = 1; i < 1001; i++)
          {
            if ((i % 3) == 0 && (i % 5) == 0)
            {
              Console.Write("sweet'nSalty ");
              sweetnSalty++;
            }
            else if ((i % 3) == 0)
            {
              Console.Write("sweet ");
              sweet++;
            }
            else if ((i % 5) == 0)
            {
              Console.Write("salty ");
              salty++;
            }
            else
            {
              Console.Write(i + " ");
            }
          }
          Console.WriteLine("Sweet: " + sweet);
          Console.WriteLine("Salty: " + salty);
          Console.WriteLine("Sweet'nSalty: " + sweetnSalty);
        }
    }
}
