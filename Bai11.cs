using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai11
    {
        public void dap_an()
        {
            int a, b;
            Boolean c = true;
            Console.WriteLine("Nhap so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c = false);
            }
            Console.ReadKey();
        }
    }
    
}
