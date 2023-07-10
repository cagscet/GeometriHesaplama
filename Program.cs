using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekilleriHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Geometri Uygulamasına Hoşgeldiniz...");
            Console.WriteLine();

            int sekil = 1;
            string cevap;

            
            
                Console.WriteLine("Hangi şeklin alanını hesaplamak istersiniz ?");
                Console.WriteLine();
                Console.WriteLine("A-) Küp ");
                Console.WriteLine("B-) Dikdörtgen prizma");
                Console.WriteLine("C-) Üçgen prizma ");
                Console.WriteLine("D-) Çember ");
                Console.WriteLine();
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                Console.WriteLine("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "A" || cevap == "a")
                {
                    int ayrıt1, ayrıt2, ayrıt3, carpma;
                    Console.WriteLine();
                    Console.Write("ilk ayrıtı giriniz :");
                    ayrıt1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("ikinci ayrıtı giriniz : ");
                    ayrıt2 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("üçüncü ayrıtı giriniz : ");
                    ayrıt3 = Convert.ToInt16(Console.ReadLine());
                    carpma = ayrıt1 * ayrıt2 * ayrıt3;
                    Console.WriteLine("küpünüzün alanı : " + carpma);

                }

                if (cevap == "B" || cevap == "b")
                {
                    int ayrıt1, ayrıt2, ayrıt3, carpma;
                 Console.WriteLine();
                 Console.Write("ilk ayrıtı giriniz :");
                 ayrıt1 = Convert.ToInt16(Console.ReadLine());
                 Console.Write("ikinci ayrıtı giriniz : ");
                 ayrıt2 = Convert.ToInt16(Console.ReadLine());
                 Console.Write("üçüncü ayrıtı giriniz : ");
                 ayrıt3 = Convert.ToInt16(Console.ReadLine());
                 carpma = ayrıt1 * ayrıt2 * ayrıt3;
                 Console.WriteLine("Dikgörtgen prizmanınızın alanı : " + carpma);
                }

            if (cevap == "C" || cevap == "c")
            {
                int Hnoktası, taban, bolme;
                Console.WriteLine();
                Console.Write("H değerini giriniz :");
                Hnoktası = Convert.ToInt16(Console.ReadLine());
                Console.Write("Taban değerini giriniz : ");
                taban = Convert.ToInt16(Console.ReadLine());
                bolme = (Hnoktası * taban) /2;
                Console.WriteLine("Üçgenin alanı : " + bolme);
            }

            if (cevap == "D" || cevap == "d")
            {
                int ayrıt1, ayrıt2, carpma;
                Console.WriteLine();
                Console.Write("yarı çapı giriniz :");
                ayrıt1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("π değerini giriniz : ");
                ayrıt2 = Convert.ToInt16(Console.ReadLine());
                carpma = ayrıt1 * ayrıt1 * ayrıt2;
                Console.WriteLine("Çemberinizin  alanı : " + carpma);
            }


            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");






            Console.Read();
        }
    }
}
