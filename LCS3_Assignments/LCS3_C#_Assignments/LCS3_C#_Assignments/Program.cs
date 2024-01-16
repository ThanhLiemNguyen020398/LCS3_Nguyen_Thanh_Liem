using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS3_C__Assignments
{
    /*
     * Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay
không. Hiển thị kết quả ra màn hình
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());

                if (n % 3 == 0)
                {
                    Console.WriteLine(" Số vừa nhập là {0} và chia hết cho 3", n);
                }
                else Console.WriteLine(" Số vừa nhập là {0} và không chia hết ch0 3", n);
                Console.ReadKey();
            

        }
    }
}
