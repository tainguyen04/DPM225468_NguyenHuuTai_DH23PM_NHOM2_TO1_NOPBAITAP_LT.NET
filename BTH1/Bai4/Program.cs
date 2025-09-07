
using System.Text;
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen mangSoNguyen = new MangSoNguyen();
            int n;
            Console.Write("Nhập vào sô phần tử của mảng: ");
            n = mangSoNguyen.NhapSoDuong();
            int[] a = new int[n];
            mangSoNguyen.NhapMang(a);
            Console.WriteLine("Số lớn nhât trong mảng là {0}", mangSoNguyen.TimMax(a));
            Console.WriteLine("Số nhỏ nhât trong mảng là {0}", mangSoNguyen.TimMin(a));
            Console.WriteLine("Tổng các phần tử trong mảng là {0}", mangSoNguyen.TinhTong(a));
            Console.WriteLine("Mảng Sắp xếp tăng dần");
            mangSoNguyen.SapXep(a);
            mangSoNguyen.InMang(a);
            Console.ReadLine();
        }
    }
}