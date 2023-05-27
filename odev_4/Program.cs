using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c_toplam = 0;
            int t_toplam = 0;

            int a = 0;
            while (a <= 20)
            {
                if (a % 2 == 0)
                {
                    c_toplam += a;
                }
                else
                {
                    t_toplam = t_toplam + a;
                }
                a++;
            }
            Console.WriteLine("Çift Sayıların Toplamı : " + c_toplam);
            Console.WriteLine("Tek Sayıların Toplamı : " + t_toplam);
            Console.ReadKey();
        }
    }
}
