using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class Program
    {
        //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bảng cửu chương " +  n); 
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("{2} * {0} = {1}", i, n * i, n);         
            }
            Console.ReadKey();
        }
    }
}
