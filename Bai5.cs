using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai5
    {
        public void dap_an()
        {
            int a, b;
            Console.WriteLine("Nhap vao so a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so b");
            b = Convert.ToInt32(Console.ReadLine());
            int phep_tinh;
             Console.WriteLine("Lua chon phep tinh + , - , * ,/");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("Moi lua chon cua ban");
                phep_tinh = Convert.ToInt32(Console.ReadLine());
            switch (phep_tinh)
            {
                case 1:
                    int cong;
                    cong = a + b;
                    Console.WriteLine("Phep tinh cong a + b = " + cong);
                    break;
                case 2:
                    int tru;
                    tru = a - b;
                    Console.WriteLine("Phep tinh tru a - b= " + tru);
                    break;
                case 3:
                    int nhan;
                    nhan = a * b;
                    Console.WriteLine("Phep tinh nhan a * b = " + nhan);
                    break;
                case 4:
                    int chia;
                    chia = a / b;
                    Console.WriteLine("Phep tinh chia a/b= " + chia);
                    break;
                default:
                    Console.WriteLine("Vui long nhap phep tinh");
                    break;

            }
            Console.ReadKey();
        }
    }
}
