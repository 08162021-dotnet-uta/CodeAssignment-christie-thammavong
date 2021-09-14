using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          /// <summary>
          /// These variables hold the count values.
          /// They are incremented in their respective
          /// if statements.
          /// </summary>
          int sweet = 0;
          int salty = 0;
          int sweetnSalty = 0;
          for (int i = 1; i < 1001; i++)
          {
            /// <summary>
            /// This if statement checks if the number
            /// is divisible by 3 and 5. This is first
            /// because it's the most specific.
            /// </summary>
            /// <param name="3)"></param>
            /// <returns></returns>
            if ((i % 3) == 0 && (i % 5) == 0)
            {
              Console.Write("sweet'nSalty ");
              sweetnSalty++;
            }
            /// <summary>
            /// This else-if statement checks if the 
            /// number is divisible by 3.
            /// </summary>
            /// <param name="3)"></param>
            /// <returns></returns>
            else if ((i % 3) == 0)
            {
              Console.Write("sweet ");
              sweet++;
            }
            /// <summary>
            /// This else-if statement checks if the
            /// number is divisible by 5.
            /// </summary>
            /// <param name="5)"></param>
            /// <returns></returns>
            else if ((i % 5) == 0)
            {
              Console.Write("salty ");
              salty++;
            }
            /// <summary>
            /// This else statement just prints the number
            /// if it is not divisible by 3 and/or 5.
            /// </summary>
            /// <value></value>
            else
            {
              Console.Write(i + " ");
            }
            /// <summary>
            /// This if statement checks if the current
            /// number is divisible by 10. If it is,
            /// start a new line. This is for printing
            /// numbers in groups of 10 per line.
            /// </summary>
            if (i % 10 == 0)
            {
              Console.WriteLine();
            }
          }
          Console.WriteLine("Sweet: " + sweet);
          Console.WriteLine("Salty: " + salty);
          Console.WriteLine("Sweet'nSalty: " + sweetnSalty);
        }
    }
}
