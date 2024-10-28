using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakinDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            string password;

            Console.Write("Lütfen Şifre Giriniz: ");
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            string capital, country;

            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "Ankara" && country == "Türkiye")
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }

            int number;

            Console.Write("Bir Sayı Giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 11)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Yanlış");
            }

            int exam1, exam2, exam3, average;
            string result;

            Console.Write("1. Sınav Notunu Giriniz: ");
            exam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sınav Notunu Giriniz: ");
            exam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Sınav Notunu Giriniz: ");
            exam3 = Convert.ToInt32(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.Write("Ortalama: " + average);

            if (average > 0 && average < 50)
            {
                result = " Kaldınız";
            }
            else if (average >= 50 && average < 70)
            {
                result = " Geçtiniz";
            }
            else if (average >= 70 && average < 85)
            {
                result = " İyi";
            }
            else if (average >= 85 && average <= 100)
            {
                result = " Çok İyi";
            }
            else
            {
                result = "Hatalı Giriş";
            }

            Console.WriteLine(result);

            string city;

            Console.Write("Bir Şehir Giriniz: ");
            city = Console.ReadLine();

            if (city == "Ankara" || city == "İstanbul" || city == "İzmir")
            {
                Console.WriteLine("Bu Şehir Büyükşehir");
            }
            else
            {
                Console.WriteLine("Bu Şehir Büyükşehir Değil");
            }

            string username;

            Console.Write("Kullanıcı Adını Giriniz: ");
            username = Console.ReadLine();

            if (username == "admin")
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Hatalı");
            }

            #endregion

            #region Mod Operator

            int number1, number2, resultMod;

            Console.Write("Bir Sayı Giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bir Sayı Giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            resultMod = number1 % number2;

            Console.WriteLine("1.Sayının 2.Sayıya Bölümünden Kalan: " + resultMod);

            int number3;
            Console.Write("Bir Sayı Giriniz: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }

            #endregion

            #region Char if
            char team;

            Console.Write("Bir Takım Giriniz: ");
            team = Convert.ToChar(Console.ReadLine());

            if (team == 'F' || team == 'B' || team == 'G')
            {
                Console.WriteLine("Bu Takım Süper Ligde");
            }
            else
            {
                Console.WriteLine("Bu Takım Süper Ligde Değil");
            }

            #endregion

            #region Örnek Proje

            Console.Write("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Ana Yemekler");
            Console.WriteLine("2. Çorbalar");
            Console.WriteLine("3. Pizzalar");
            Console.WriteLine("4. İçecekler");
            Console.WriteLine("5. Tatlılar");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("Detaylar İçin Menüden Bir Ürün Seçiniz: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("------ Ana Yemekler Menüsü ------");
                Console.WriteLine("1. Kuru Fasulye");
                Console.WriteLine("2. İzmir Köfte");
                Console.WriteLine("3. Tavuk Şiş");
                Console.WriteLine("4. Kuzu Tandır");
                Console.WriteLine("5. Kavurma");
                Console.WriteLine();
            }
            else if (menuItem == "2")
            {
                Console.WriteLine("------ Çorbalar Menüsü -----");
                Console.WriteLine("1. Mercimek Çorbası");
                Console.WriteLine("2. Tarhana Çorbası");
                Console.WriteLine("3. Tavuk Çorbası");
                Console.WriteLine("4. Domates Çorbası");
                Console.WriteLine("5. Sebze Çorbası");
                Console.WriteLine();
            }
            else if (menuItem == "3")
            {
                Console.WriteLine("------ Pizzalar Menüsü ------");
                Console.WriteLine("1. Sucuklu Pizza");
                Console.WriteLine("2. Kavurmalı Pizza");
                Console.WriteLine("3. Mantarlı Pizza");
                Console.WriteLine("4. Kıymalı Pizza");
                Console.WriteLine("5. Karışık Pizza");
                Console.WriteLine();
            }
            else if (menuItem == "4")
            {
                Console.WriteLine("----- İçecekler Menüsü ------");
                Console.WriteLine("1. Ayran");
                Console.WriteLine("2. Kola");
                Console.WriteLine("3. Fanta");
                Console.WriteLine("4. Sprite");
                Console.WriteLine("5. Limonata");
                Console.WriteLine();
            }
            else if (menuItem == "5")
            {
                Console.WriteLine("----- Tatlılar Menüsü ------");
                Console.WriteLine("1. Kadayıf");
                Console.WriteLine("2. Baklava");
                Console.WriteLine("3. Sütlaç");
                Console.WriteLine("4. İrmik Helvası");
                Console.WriteLine("5. Kemalpaşa");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
            }





            #endregion

            #region Switch Case

            Console.Write("Lütfen Ay Giriniz: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş");
                    break;
            }

            #endregion

            #region Switch Case Hesap Makinesi

            int number11, number12, resultHM;
            char sybmol;

            Console.WriteLine("***** Hesap Makinesi *****");

            Console.Write("1. Sayıyı Giriniz: ");
            number11 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number12 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlemi Giriniz: ");
            sybmol = Convert.ToChar(Console.ReadLine());

            switch (sybmol)
            {
                case '+':
                    resultHM = number11 + number12;
                    Console.WriteLine("Toplam: " + resultHM);
                    break;
                case '-':
                    resultHM = number11 - number12;
                    Console.WriteLine("Fark: " + resultHM);
                    break;
                case '*':
                    resultHM = number11 * number12;
                    Console.WriteLine("Çarpım: " + resultHM);
                    break;
                case '/':
                    resultHM = number11 / number12;
                    Console.WriteLine("Bölüm: " + resultHM);
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş");
                    break;
            }
            #endregion

            Console.Read();
        }
    }
}