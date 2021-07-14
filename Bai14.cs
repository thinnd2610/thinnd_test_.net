using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai14
    {
        public void dap_an()
        {
            int a;
            Console.WriteLine("Nhap vao so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Day la so chan");
            }
            else
            {
                Console.WriteLine("Day la so le");
            }
            Console.ReadKey();
        }
    }
}
