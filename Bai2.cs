using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai2
    {
        public void dap_an()
        {
            Console.Write("Nhap mot so : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap do rong cua tam giac: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }

            Console.ReadKey();
        }
    }
}
