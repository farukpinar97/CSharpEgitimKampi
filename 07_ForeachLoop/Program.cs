using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:DeğişkenTürü
            //2:DeğişkenAdı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 24, 32, 53, 12, 57, 23, 63 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 24, 32, 53, 12, 57, 23, 63 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2== 0) {  Console.WriteLine(i); }
            //}

            //int[] numbers = { 45, 24, 32, 53, 12, 57, 23, 63 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total+=i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6,8
            //};

            //foreach (int i in numbers) { 
            //Console.WriteLine(i);
            //}

            //string word = "merhaba";

            //foreach (char c in word) { 
            //Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            
            // Kullanıcıdan sınıftaki öğrenci sayısını alma
            Console.WriteLine("-------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAverage=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notu : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;
            }

            
            //Sınav ortalamarı
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAverage[i]}");

                // Öğrencinin ortalaması ve geçip kalma durumları
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("--------------");
            }
                
            
            #endregion
            Console.Read();
        }
    }
}
