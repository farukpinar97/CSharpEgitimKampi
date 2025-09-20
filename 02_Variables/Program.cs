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
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice,tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün : - Elma " + "- Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " TL" + " - Toplam Tutar : " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : - Portakal " + "- Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " TL" + " - Toplam Tutar : " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : - Çilek " + "- Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " TL" + " - Toplam Tutar : " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : - Patates " + "- Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + " TL" + " - Toplam Tutar : " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : - Domates " + "- Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " TL" + " - Toplam Tutar : " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF....
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerDisctrict, passangerCity, passangerAge,passangerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passangerDisctrict = Console.ReadLine();

            //Console.Write("İl Bilgisi : ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı : ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No : ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");

            //Console.WriteLine("Yolcu TC Kimlik No : " + passangerIdentityNumber + " Yolcu Ad Soyad : " + passangerName + " " + passangerSurname + " " + passangerDisctrict + "/" +passangerCity + " " + passangerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1,exam2,exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine(result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " +gender);
            #endregion

            Console.Read();
        }
    }
}
