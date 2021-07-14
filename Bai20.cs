using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai20
    {
        public void dap_an()
        {
            int a, b, c;

            Console.WriteLine("Nhap so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("So a la so lon nhat  " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("So b lon nhat la " + b);
            }
            else
            {
                Console.WriteLine("So c la so lon nhat" + c);
            }
            Console.ReadKey();
        }
    }
}
