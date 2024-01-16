using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số hàng n, vẽ tam giác *với số hàng tương ứng. 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());

            //for(int i = 1;i <= n;i++) 
            //{
            //    for(int j = 1;j <=i  ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
