using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    //Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển
    //thị kết quả ra màn hình
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so nguyen n ");
            int n = int.Parse(Console.ReadLine());
            int giaithua = 1;
            int tonggiaithua = 0;
            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    //Console.Write(j);
                    giaithua *= j;
                   
                }
                Console.WriteLine(" Giai thừa của i = {1} là {0}   ", giaithua, i);
                tonggiaithua += giaithua;
                Console.WriteLine("Tổng giai thừa " + tonggiaithua);
                giaithua = 1;
                Console.WriteLine("//////");
            }  
            Console.WriteLine("Tổng giai thừa từ 1 đến n là " + tonggiaithua);
            Console.ReadKey();

        }
        
    }
}
