using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForeachLoop

            //Foreach(1;2;3;4)

            //1- Değişken tanımlanır.
            //2- Dizi belirtilir.
            //3- Dizi içinde dolaşılır.
            //4- Dizi içindeki elemanlar değişkene atanır.

            string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            int[] numbers = { 50, 60, 71, 83, 95, 100, 117, 120, 130, 140 };

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int[] numbers2 = { 50, 60, 71, 83, 95, 100, 117, 120, 130, 140 };

            int total = 0;

            foreach (int number in numbers2)
            {
                total += number;
            }
            Console.WriteLine(total);


            List<int> numbers3 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            string word = "Hello World";

            foreach (char character in word)
            {
                Console.WriteLine(character);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
