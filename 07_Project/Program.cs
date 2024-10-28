using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Örnek Sınac Sistemi (Öğrenci Notları)

            Console.WriteLine("*** Öğrenci Notları Sistemi*** ");
            Console.WriteLine();

            // Öğrenci sayısını kullanıcıdan alınız.
            Console.Write("Lütfen öğrenci sayısını giriniz: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Öğrenci adlarını ve notlarını saklayacak diziler.
            string[] studentNames = new string[studentCount];
            double[] studentGrades = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. adlı öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}. adlı öğrencinin {j + 1}. sınav sonucunu giriniz: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value;
                }

                studentGrades[i] = totalExamResult / 3;

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]}. adlı öğrencinin not ortalaması: {studentGrades[i]}");

                if (studentGrades[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]}. adlı öğrenci sınıfı geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}. adlı öğrenci sınıfta kaldı.");
                }
            }

            Console.ReadLine();
            #endregion

        }
    }
}
