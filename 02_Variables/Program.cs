using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler

            Console.WriteLine("***** Fiyat Listesi *****");

            double applePrice, oranPrice, strawberryPrice, patatoPrice, tomatoPrice;

            applePrice = 2.5;
            oranPrice = 3.5;
            strawberryPrice = 4.5;
            patatoPrice = 1.5;
            tomatoPrice = 2.0;

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + oranPrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            Console.WriteLine();

            double appleGram = 1.245;
            double oranGram = 2.650;
            double strawberryGram = 1.000;
            double patatoGram = 4.800;
            double tomatoGram = 3.750;

            double appleTotalPrice = applePrice * appleGram;
            double oranTotalPrice = oranPrice * oranGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double patatoTotalPrice = patatoPrice * patatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            double totalPrice = appleTotalPrice + oranTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("---- Elma Toplam Fiyatı: " + appleTotalPrice + " TL");
            Console.WriteLine("---- Portakal Toplam Fiyatı: " + oranTotalPrice + " TL");
            Console.WriteLine("---- Çilek Toplam Fiyatı: " + strawberryTotalPrice + " TL");
            Console.WriteLine("---- Patates Toplam Fiyatı: " + patatoTotalPrice + " TL");
            Console.WriteLine("---- Domates Toplam Fiyatı: " + tomatoTotalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Fiyat: " + totalPrice + " TL");

            #endregion

            #region CharDeğişkenler

            char symbol;
            symbol = 'A';

            Console.WriteLine("Karakter: " + symbol);


            #endregion

            #region KlavyedenVeriAlma

            Console.WriteLine("***** KOMUTAN Hava Yolları Yolcu Bilgisi ******");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Şehir: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu T.C. Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");

            Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " ");


            #endregion

            #region KlavyedenVeriAlma2

            int shoePrice, computerPrice, chairPrice, tvPrice;

            shoePrice = 1000;
            computerPrice = 5000;
            chairPrice = 250;
            tvPrice = 3000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Ayakkabı Adet: ");
            shoeCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bilgisayar Adet: ");
            computerCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sandalye Adet: ");
            chairCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Televizyon Adet: ");
            tvCount = Convert.ToInt32(Console.ReadLine());

            int totalShoePrice = shoePrice * shoeCount;
            int totalComputerPrice = computerPrice * computerCount;
            int totalChairPrice = chairPrice * chairCount;
            int totalTvPrice = tvPrice * tvCount;

            int totalPrice2 = totalShoePrice + totalComputerPrice + totalChairPrice + totalTvPrice;

            Console.Write("Toplam Fiyat: " + totalPrice2 + " TL");

            #endregion

            #region KlavyedenVeriAlma3

            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav Notu: ");
            exam1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sınav Notu: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notu: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine("Ortalama: " + result);

            #endregion

            #region KlavyedenVeriAlma4

            char gender;
            Console.Write("Cinsiyet (E/K): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Seçtiginiz cinsiyet: ");

            #endregion

            Console.ReadLine();
        }
    }
}
