using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDöngüsü

            //for (x;y;z)
            //x: Başlangıç değeri
            //y: Koşul
            //z: Artış miktarı

            int i;

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("C# Eğitim Kampı");
            }

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.Write("Lütfen bir sayı giriniz: ");
            int finishValue = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }

            #endregion

            #region ForDöngüsüİleKararYapıları

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Sayısı Çifttir.");
                }
                else
                {
                    Console.WriteLine(i + " Sayısı Tektir.");
                }
            }

            int totalValue = 0;

            for (i = 1; i <= 10; i++)
            {
                totalValue += i;
            }

            Console.WriteLine("Toplam Değer: " + totalValue);

            int totalValue2 = 0;

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue2 += i;
                }
            }

            Console.WriteLine("Çift Sayıların Toplam Değeri: " + totalValue2);

            int count = 0;
            for (i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("1-50 arasında 7'ye bölünebilen sayı adedi: " + count);

            int bacteriumCount = 1;

            for (i = 1; i <= 24; i++)
            {
                bacteriumCount *= 2;
                Console.WriteLine(i + ". Saat Sonundaki Bakteri Sayısı: " + bacteriumCount);
            }

            #endregion

            #region WhileDöngüsü

            //while (koşul)
            //{
            //  //Koşul sağlandığı sürece çalışacak kodlar
            //}

            int j = 1;

            while (j <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                j++;
            }

            int k = 1;
            while (k <= 10)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }

            int l = 1;
            int sum = 0;

            while (l <= 10)
            {
                sum += l;
                l++;
            }

            Console.WriteLine(sum);

            #endregion

            #region ÖrnekSınavSorusu

            //Klavyeden girilen 3 basamaklı bir sayının basamakları toplamını ekrana yazdıran programı yazınız.

            Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int hundred = number / 100;
            int ten = (number % 100) / 10;
            int unit = number % 10;

            #endregion

            Console.Read();
        }
    }
}
