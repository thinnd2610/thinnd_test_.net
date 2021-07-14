using System;

namespace Bai_Tap
{
    //11. Nhập hai số từ bàn phím, trả về true nếu cả hai số cùng chẵn, nếu không thì trả về false.
    class Program
    {
    
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("-----Bai tap-----");
                Console.WriteLine("1. Bai 2");
                Console.WriteLine("2. Bai 5");
                Console.WriteLine("3. Bai 8");
                Console.WriteLine("4. Bai 11");
                Console.WriteLine("5. Bai 14");
                Console.WriteLine("6. Bai 17");
                Console.WriteLine("7. Bai 20");
                Console.WriteLine("8. Bai 23");
                Console.WriteLine("9. Bai 26");
                Console.WriteLine("10. Bai 29");
                Console.WriteLine("11. Bai 31");
                Console.WriteLine("12. Bai 32");
                Console.WriteLine("Moi lua chon cua ban :");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
            {
                case 1:
                        Bai2 bai2 = new Bai2();
                        bai2.dap_an();
                    break;
                case 2:
                        Bai5 bai5 = new Bai5();
                        bai5.dap_an();

                    break;
                case 3:
                        Bai8 bai8 = new Bai8();
                        bai8.dap_an();

                    break;
                case 4:
                   Bai11 b11 = new Bai11();
                            b11.dap_an();
                    break;
                case 5:
                        Bai14 b14 = new Bai14();
                        b14.dap_an();
                    break;
                case 6:
                        Bai17 bai17 = new Bai17();
                        bai17.dap_an();
                    break;
                case 7:
                        Bai20 bai20 = new Bai20();
                        bai20.dap_an();

                    break;
                case 8:
                        Bai23 bai23 = new Bai23();
                        bai23.dap_an();

                    break;
                case 9:
                        Bai26 bai26 = new Bai26();
                    break;
                case 10:
                        Bai29 bai29 = new Bai29();
                        bai29.dap_an();
                    break;
                case 11:
                        Bai31 bai31 = new Bai31();
                        bai31.dap_an();
                    break;
                case 12:
                        Bai32 bai32 = new Bai32();
                        bai32.dap_an();
                    break;
                default:
                        Console.WriteLine("Moi lua chon cua ban");
                    break;
            }
            } while (chon>0||chon>32);
            
            Console.ReadKey();
        }
    }
}
