using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AltAltaOnYıldız

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }

            #endregion

            #region YanyanaOnYıldız

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }

            #endregion

            #region YanyanaOnYıldızAltAlta

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }

            #endregion

            #region DikYıldız

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region TersDikYıldız

            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Baklava

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
