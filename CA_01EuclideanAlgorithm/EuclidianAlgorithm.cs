using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_01EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //oklid algoritmasi -- en buyuk ortak bolen

          
              
             //1.yontem 
             
            int sayi1, sayi1y, sayi2, sayi2y, enBuyukOrtakBolen=1;
            Console.WriteLine("can you give me first number: ");
            sayi1y=sayi1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("can you give me second number: ");
            sayi2y=sayi2 = Convert.ToInt32(Console.ReadLine());
            
            int[] asalSayilar = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            
            for (int i = 0; i < asalSayilar.Length; i++)
            {
                while (sayi1 % asalSayilar[i] == 0 && sayi2 % asalSayilar[i] == 0)
                {
                    if (sayi1 % asalSayilar[i] == 0 && sayi2 % asalSayilar[i] == 0)
                    {
                        enBuyukOrtakBolen *= asalSayilar[i];
                    }

                    sayi1 /= asalSayilar[i];
                    sayi2 /= asalSayilar[i];
                }
            }
            Console.WriteLine($"{sayi1y} ve {sayi2y}'un en buyuk ortak boleni: {enBuyukOrtakBolen}'dir.");
            Console.ReadKey();
            


        }
    }
}
