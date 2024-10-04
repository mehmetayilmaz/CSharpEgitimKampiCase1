using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string,integer değişkenler ve yazdırma komutları
            //int age;
            //string name;

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("**************");
            //age = 36;
            //name = "mehmet";

            //Console.WriteLine("İsim="+ name+ " "+ "Yaş="+age );

            #endregion

            #region örnek uygulama
            //int waterCont = 2;
            //int colaCount = 1;
            //int teaCont = 2;
            //int coffeaCount = 1;

            //int waterPrice = 10;
            //int colaPrice = 15;
            //int teaPrice = 8;
            //int coffeaPrice = 25;

            //int totalPrice = waterCont * waterPrice + colaCount * colaPrice + teaCont * teaPrice + coffeaCount * coffeaPrice;
            //Console.WriteLine("Toplam Hesap="+totalPrice);




            #endregion

            #region double değişkenler 
            //double exam1 = 67.5;
            //double exam2 = 43.5;
            //double exam3 = 84.5;

            //double average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama="+average);















            #endregion

            #region char değişkenler
            //char gender = 'E';
            //char age = '6';
            //Console.WriteLine( "Cinsiyet ve Yaş="+gender+ " "+age);
            #endregion

            #region klavyeden veri girişleri ve dönüşümler
            Console.WriteLine("Yolcu İsmi");
            Console.WriteLine("İsim=");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisim=");
            string surName = Console.ReadLine();
            Console.WriteLine("Yaş=");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("TC Kimlik No=");
            string identyNumber = Console.ReadLine();
            Console.WriteLine("Bilet Fiyatı");
            double price=double.Parse(Console.ReadLine());

            Console.WriteLine(" İsim = " + name + "Soyisim = " + surName +
                "/" + "Yaş =  " + age + " / " + " TC No = " + identyNumber+"///"+"Bilet Fiyatı="+price);




            #endregion

            Console.ReadKey();

        }
    }
}
