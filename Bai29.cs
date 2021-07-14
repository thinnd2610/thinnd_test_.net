using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai29
    {
        public void dap_an() 
        {
            Console.WriteLine("Nhap 1 ngay trong tuan 2-8");
            int a;
            do
            {

                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vui long nhap tu 2-8");

            } while (a < 2 || a > 8);

            switch (a)
            {
                case 2:
                    Console.WriteLine("Thu 2");
                    break;
                case 3:
                    Console.WriteLine("Thu 3");
                    break;
                case 4:
                    Console.WriteLine("Thu 4");
                    break;
                case 5:
                    Console.WriteLine("Thu 5");
                    break;
                case 6:
                    Console.WriteLine("Thu 6");
                    break;
                case 7:
                    Console.WriteLine("Thu 7");
                    break;
                case 8:
                    Console.WriteLine("Chu nhat");
                    break;
                default:
                    Console.WriteLine("Vui long nhap du lieu");
                    break;
            }
        }
    }
}
