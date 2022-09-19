using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, ort;
            Console.Write("1.Sınav notunuzu giriniz :");
            s1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sınav Notunuzu Giriniz :");
            s2=Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("Ortalamanız :" + ort);
            if (ort >= 50)
            {
                Console.WriteLine("**** Tebrikler Geçtiniz **** ");
            }
            else
            {
                Console.WriteLine("**** Kaldınız ****  ");
            }
            Console.Read();

            

            
        }
    }
}
