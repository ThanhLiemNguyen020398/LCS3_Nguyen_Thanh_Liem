using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là
            //số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());
            bool kt = false;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                Console.WriteLine(Math.Sqrt(n));
                if (i * i == n)
                {
                    Console.WriteLine(n + " là số chính phương");
                    kt = true;
                    break;
                }
                
            }
            if ( kt == false) Console.WriteLine(n + " không là số chính phương");
            Console.ReadKey();

            
        }
    }
}
