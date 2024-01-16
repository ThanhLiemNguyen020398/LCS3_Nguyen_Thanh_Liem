using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS3_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tháng");
            int n = int.Parse(Console.ReadLine());

            //// dieu kien n>0
            //if (n >= 0)   Console.WriteLine(" Gia tri n = {0} \n Gia tri nhap vao lon hon 0", n);
            //string noidung = (n > 0) ? "n lớn hơn 0 " : "n bé hơn 0";
            //Console.WriteLine(n >= 0 ? " n Lon hon 0 " : "N Be Hon 0");
            //Console.WriteLine(noidung ?? "Gia tri nhap vao khac 0"); 
            // ?? kiem tra noidung co khac null hay khong
            // khong lồng if quá 4 cấp  
            switch(n)
            {
                case 1: case 3: case 5: case 7: case 8: case 11:
                    Console.WriteLine(" Tháng có 31 ngày");
                    break;
                case 2: Console.WriteLine(" Tháng có 28 hoặc 29 ngày");
                    break;
                default:
                    Console.WriteLine("Tháng có 30 ngày");
                    break;
            }       
            
            Console.ReadKey(); 
        }
    }
}
