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

           
              
             //2.yontem 

            int sayi1, sayi1y, sayi2, sayi2y;
            Console.WriteLine("can you give me first number: ");
            sayi1y=sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("can you give me second number: ");
            sayi2y=sayi2 = Convert.ToInt32(Console.ReadLine());

            while (sayi2>0)
            {
                int mod = sayi1 % sayi2;

                sayi1 = sayi2;
                sayi2 = mod;
            }
            Console.WriteLine($"{sayi1y} ve {sayi2y}'un en buyuk ortak boleni: {sayi1}'dir.");
            Console.ReadKey();
           
        }
    }
}
