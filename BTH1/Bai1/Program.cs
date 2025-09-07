using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat timSoLonNhat = new TimSoLonNhat();
            int a, b, c, max;
            Console.Write("Nhập a= ");
            a = timSoLonNhat.NhapMotSo();
            Console.Write("Nhập b= ");
            b = timSoLonNhat.NhapMotSo();
            Console.Write("Nhập c= ");
            c = timSoLonNhat.NhapMotSo();
            max = timSoLonNhat.TimMax(a, b, c);
            Console.WriteLine("Số lớn nhất trong 3 số {0},{1},{2} là {3}", a, b, c, max);
            Console.ReadLine();
        }
    }
}