using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap
{
    class Bai17
    {
        public void dap_an()
        {
            int a;
            Console.WriteLine("HOI DONG BAU CU QUOC GIA");
            Console.WriteLine("KIEM TRA TUOI CUA BAN DA DU TUOI DI BAU CU HAY CHUA ?");
            Console.WriteLine("Hay nhap tuoi cua ban : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("Xin loi , ban chua du tuoi lam chuyen ay | tuoi bau cu tu 18 +");
            }
            else
            {
                Console.WriteLine("Ban da du tuoi di bau cu | Hay bau chon cho toi nhe : NGO DUC THIN - SBD : 2610 | XIN CAM ON !");
            }
            Console.ReadKey();
        }
    }
}
