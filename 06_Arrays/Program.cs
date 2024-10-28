using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TemelDiziÖrnekleri

            string[] colors = new string[4];

            colors[0] = "Red";
            colors[1] = "Blue";
            colors[2] = "Green";
            colors[3] = "Yellow";

            Console.WriteLine(colors[0]);

            string[] cities = new string[5];

            cities[0] = "İstanbul";
            cities[1] = "Ankara";
            cities[2] = "İzmir";
            cities[3] = "Bursa";
            cities[4] = "Antalya";

            Console.WriteLine(cities[0]);

            int[] numbers = new int[10];

            numbers[0] = 50;
            numbers[1] = 60;
            numbers[2] = 70;
            numbers[4] = 90;
            numbers[5] = 100;
            numbers[7] = 120;
            numbers[9] = 140;

            Console.WriteLine(numbers[0]);

            string[] cities2 = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };

            Console.WriteLine(cities2[0]);

            #endregion

            #region DiziElemanlarınıDöngüİleYazdırma

            string[] colors2 = { "Red", "Blue", "Green", "Yellow" };

            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }

            int[] numbers2 = { 50, 60, 70, 80, 90, 100, 110, 120, 130, 140 };

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 0)
                {
                    Console.WriteLine(numbers2[i]);
                }
            }

            char[] chars = { 'a', 'b', 'c', 'd' };

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            #endregion

            #region EnBüyükSayıyıBulma

            int[] numbers3 = { 35, 42, 21, 87, 12, 19, 45, 87 };

            int max = numbers3[0];

            for (int i = 1; i < numbers3.Length; i++)
            {
                if (numbers3[i] > max)
                {
                    max = numbers3[i];
                }
            }

            int[] numbers4 = { 35, 42, 21, 87, 12, 19, 45, 87 };
            Array.Sort(numbers4);
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine(numbers4[i]);
            }

            int[] numbers5 = { 35, 42, 21, 87, 12, 19, 45, 87 };
            Array.Reverse(numbers5);
            for (int i = 0; i < numbers5.Length; i++)
            {
                Console.WriteLine(numbers5[i]);
            }



            #endregion

            #region DiziMetodları

            string[] customers = { "Engin", "Derin", "Salih, Doğan" };
            int index = Array.IndexOf(customers, "Derin");
            Console.WriteLine("Index: " + index);

            int[] numbers6 = { 35, 42, 21, 87, 12, 19, 45, 87 };
            Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers6.Max() + " Dizinin En Küçük Elemanı: " + numbers6.Min());

            #endregion

            #region KullanıcıdanDiziElemanlarıAlma

            string[] cities3 = new string[5];

            for (int i = 0; i < cities3.Length; i++)
            {
                Console.Write("Şehir Adı Giriniz: ");
                cities3[i] = Console.ReadLine();
            }

            Console.WriteLine("************");

            for (int i = 0; i < cities3.Length; i++)
            {
                Console.WriteLine(cities3[i]);
            }

            int[] numbers7 = { 35, 42, 21, 87, 12, 19, 45, 87 };
            int sum = 0;

            for (int i = 0; i < numbers7.Length; i++)
            {
                sum += numbers7[i];
            }

            int[] numbers8 = { 12, 23, 34, 45, 56, 67, 78, 89, 99, 120 };

            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers8.Length; i++)
            {
                if (numbers8[i] % 2 == 0)
                {
                    Console.WriteLine(numbers8[i]);
                }
            }

            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers8.Length; i++)
            {
                if (numbers8[i] % 2 != 0)
                {
                    Console.WriteLine(numbers8[i]);
                }
            }




            #endregion

            Console.ReadLine();
        }
    }
}
