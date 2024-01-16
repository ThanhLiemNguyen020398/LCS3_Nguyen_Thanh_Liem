using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bai_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị
            //kết quả ra màn hình.
            //𝑆 = 1 + 22 + 33 + 44 + ⋯ + 𝑛𝑛

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());

            long tong = 0;
            for (int i = 1;i <= n;i++) 
            {
          
                tong = tong + (long)Math.Pow(i,i);
            }
            Console.WriteLine("Tổng lũy thừa từ 1 đến " + n + " là " + tong);
            Console.ReadKey();
        }
    }
}
