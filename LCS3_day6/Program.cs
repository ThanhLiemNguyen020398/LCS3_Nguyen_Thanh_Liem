using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS3_day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(TongMang(array));
            Console.ReadKey();
        }
        public static int TongMang(int[] array)
        {
            int s = 0;
            foreach (int i in array) 
            {
                s += i; 
            }
            return s;
        }
    }
}
