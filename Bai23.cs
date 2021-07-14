using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai23
    {
        public void dap_an()
        {
            int a;

            Console.WriteLine("TRUNG TAM KHI TUONG THUY VAN TRUNG UONG");
            Console.WriteLine("Vui long nhap nhiet do");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Thoi tiet gia ret");
            }
            else if (a >= 0 && a < 10)
            {
                Console.WriteLine("Thoi tiet rat lanh");
            }
            else if (a >= 10 && a < 20)
            {
                Console.WriteLine("Thoi tiet lanh");
            }
            else if (a >= 20 && a < 30)
            {
                Console.WriteLine("Thoi tiet binh thuong");
            }
            else if (a >= 30 && a < 40)
            {
                Console.WriteLine("Thoi tiet nong");

            }
            else
            {
                Console.WriteLine("Thoi tiet rat nong");
            }


            Console.ReadKey();
        }
    }
}
