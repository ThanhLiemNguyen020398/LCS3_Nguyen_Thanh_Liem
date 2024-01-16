using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong
            //tháng ra màn hình.
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Tháng " + n + " có 31 ngày");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Tháng " + n + " có 30 ngày");
                    break;
                default:
                    Console.WriteLine(" Tháng 2 có 28 hoặc 29 ngày");
                    break;
            }
            Console.ReadKey();
        }
    }
}
