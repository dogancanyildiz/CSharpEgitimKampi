using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1. Ana Yemekler");
            Console.WriteLine("2. Tatlılar");
            Console.WriteLine("3. İçecekler");
            Console.WriteLine("4. Çorbalar");
            Console.WriteLine("5. Salatalar");
            Console.WriteLine("6. Mezeler");
            Console.WriteLine();

            #endregion

            #region StrDeğişkenler

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, customerDistrict, customerCity;

            customerName = "Doğan Can";
            customerSurname = "YILDIZ";
            customerPhone = "+90 554 382 8000";
            customerEmail = "info@dogancanyildiz.com";
            customerDistrict = "Selçuklu";
            customerCity = "Konya";

            Console.WriteLine("***** Müşteri Bilgileri *****");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("E-Posta: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);

            #endregion

            #region IntDeğişkenler

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int cokePrice = 25;
            int waterPrice = 5;
            int friesPrice = 50;
            int lemonadePrice = 35;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine("Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();

            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalPizzaPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 2;
            pizzaCount = 1;
            cokeCount = 2;
            waterCount = 3;
            friesCount = 2;
            lemonadeCount = 1;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("***** Sipariş Detayları *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger Adet: " + hamburgerCount + " Toplam Fiyat: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Adet: " + pizzaCount + " Toplam Fiyat: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kola Adet: " + cokeCount + " Toplam Fiyat: " + totalCokePrice + " TL");
            Console.WriteLine("Su Adet: " + waterCount + " Toplam Fiyat: " + totalWaterPrice + " TL");
            Console.WriteLine("Patates Kızartması Adet: " + friesCount + " Toplam Fiyat: " + totalFriesPrice + " TL");
            Console.WriteLine("Limonata Adet: " + lemonadeCount + " Toplam Fiyat: " + totalLemonadePrice + " TL");
            Console.WriteLine();

            int totalOrderPrice = totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Sipariş Tutarı: " + totalOrderPrice + " TL");

            #endregion

            Console.ReadLine();
        }
    }
}
