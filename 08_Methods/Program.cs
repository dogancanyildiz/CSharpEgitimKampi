using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //()
            //Geriye değer döndürmeyen ve parametre almayan metotlar (void)
            //Geriye değer döndüren ve parametre almayan metotlar (int, string, double, ...)

            void CustomList()
            {
                Console.WriteLine("Doğan Can YILDIZ");
                Console.WriteLine("Makbule Gökçe KÖKLÜ");
            }

            CustomList();

            void Sum()
            {
                int x = 5;
                int y = 10;
                int z = x + y;
                Console.WriteLine(z);
            }

            Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }

            WriteMethod("Doğan Can YILDIZ");

            void customerCard(string firstName, string surName)
            {
                Console.WriteLine("Müşteri: " + firstName + " " + surName);
            }

            customerCard("Doğan Can", "YILDIZ");
            customerCard("Makbule Gökçe", "KÖKLÜ");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void SumMethod(int x, int y)
            {
                int result = x + y;
                Console.WriteLine(result);
            }

            SumMethod(5, 10);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            string customerName2()
            {
                return "Doğan Can YILDIZ";
            }

            customerName2();

            string studentCard()
            {
                string studentName = "Doğan Can";
                string studentSurName = "YILDIZ";

                return studentName + " " + studentSurName;
            }

            studentCard();

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            string countryCard(string countryName, string capitalName, string flagColor)
            {
                string cardInfo = "Ülke: " + countryName + " Başkent: " + capitalName + " Bayrak Rengi: " + flagColor;
                return cardInfo;
            }

            string x1, y1, z1;
            Console.Write("Ülke Adı: ");
            x1 = Console.ReadLine();

            Console.Write("Başkent Adı: ");
            y1 = Console.ReadLine();

            Console.Write("Bayrak Rengi: ");
            z1 = Console.ReadLine();

            Console.WriteLine(countryCard(x1, y1, z1));

            Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            int SumMethod2(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }

            Console.WriteLine(SumMethod2(5, 10));

            #endregion

            #region Ördek
            int examResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    Console.WriteLine(student + " adlı öğrenci sınıfı geçti." + "Ortalama: " + result);
                }
                else
                {
                    Console.WriteLine(student + " adlı öğrenci sınıfta kaldı." + "Ortalama: " + result);
                }
                return result;
            }

            Console.WriteLine(examResult("Doğan Can", 50, 60, 70));

            #endregion

            Console.ReadLine();
        }
    }
}
