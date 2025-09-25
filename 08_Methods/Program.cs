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
            #region Void Metotlar

            //()
            // Geriye Değer Döndürmeyen Metotlar
            // Customer --> Listele-Ekle-Sil-Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Fatma Çoban");
            //    Console.WriteLine("Hakan Çınar");
            //    Console.WriteLine("Ayşe Deniz");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " +surname);
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1 , int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 4, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yılmaz";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColour)
            //{
            //    string cardInfo = "Ülke : " + countryName + " | Başkent : " + capital + " | Bayrak Rengi : " + flagColour;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz : ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz : ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("İtalya", "Roma", "Beyaz-Kırmızı-Yeşil"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 15));
            //Console.WriteLine(Sum(23, 65));
            //Console.WriteLine(Sum(12, 54));
            //Console.WriteLine(Sum(32, 16));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result=(exam1 + exam2 + exam3) / 3;
                if (result >= 50) 
                {
                    return student + " isimli öğrenci sınavı geçti " + " | Ortalama : " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + " | Ortalama : " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 45, 43, 21));
            Console.WriteLine(ExamResult("Ayşe", 87, 43, 57));

            #endregion

            Console.Read();
        }
    }
}
