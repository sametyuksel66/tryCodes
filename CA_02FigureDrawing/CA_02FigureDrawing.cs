using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_02FigureDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Figure Drawing (triangle, rectangle, square / ucgen, dikdortgen, kare cizdirme)

            int a;
            int b;


            Console.WriteLine("Cizdirmek istediginiz sekli seciniz?\n 1 - dikdortgen\n 2 - kare\n 3- eskenar ucgen\n cikis icin herhangi bir tusa basin...");
            string secim = Console.ReadLine();


            if (secim == "1")
            {
                Console.WriteLine("A kenarinin uzunlugunu giriniz: ");
                bool cevap3 = int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("B kenarinin uzunlugunu giriniz: ");
                bool cevap4 = int.TryParse(Console.ReadLine(), out b);

                if (cevap3 && cevap4)
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.Write("\n");
                    }
                }
            }
            else if (secim == "2")
            {
                Console.WriteLine("Karenin kenar uzunlugunu giriniz: ");
                bool cevap5 = int.TryParse(Console.ReadLine(), out a);
                if (cevap5)
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.Write("\n");
                    }
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Eskenar ucgenin kenar uzunlugunu giriniz: ");
                bool cevap6 = int.TryParse(Console.ReadLine(), out a);
                if (cevap6)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.Write("\n");
                    }
                }
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
