using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS3_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Nhập vào số nguyên a = ");
            //int soNguyenA = int.Parse(Console.ReadLine());

            //Console.Write("Nhập vào số nguyên b = ");
            //int soNguyenB = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Số Nguyên A vừa Nhập {0}", soNguyenA);
            //Console.WriteLine(" Số Nguyên B vừa Nhập {0}", soNguyenB);

            //Console.WriteLine("Tong 2 so vua nhap la {0}", soNguyenA + soNguyenB);

            //float thuong = (float)soNguyenA / soNguyenB;
            //Console.WriteLine("Thuong 2 so vua nhap la {0}", thuong);

            //HocSinh hocSinh1 = new HocSinh();
            //hocSinh1.hoTen = "Liem";
            //hocSinh1.diaChi = "Quan 9";
            //Console.WriteLine("Ten {0}",hocSinh1.hoTen);

            //HocSinh hocSinh2 = new HocSinh("Liem Nguyen","Quan 9", 6.5f);
            //Console.WriteLine("Ten {0} dia chi {1} va diem {2}", hocSinh2.hoTen, hocSinh2.diaChi, hocSinh2.diemTrungBinh);
            thutrongtuan homnay = thutrongtuan.nam;
            int chiso = (int)homnay;
            Console.WriteLine(chiso);
            Console.ReadKey();

        }
        struct HocSinh
        {
            public string hoTen { get; set; }
            public string diaChi { get; set;}
            public float diemTrungBinh { get; set; }

            public HocSinh(string hoten, string diachi, float diemtrungbinh)// ham khoi tao
            {
                this.hoTen = hoten;
                this.diaChi = diachi;
                this.diemTrungBinh = diemtrungbinh;
            }
        }
        enum thutrongtuan { hai, ba, tu, nam, sau, bay, cn}
    }
}
