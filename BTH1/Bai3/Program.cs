using Bai3;
using System.Text;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GiaiThuaN giaiThua = new GiaiThuaN();
            int n;
            Console.Write("Nhập n = ");
            n = giaiThua.NhapMotSo();
            Console.WriteLine("Giai thừa của {0} là {1}", n, giaiThua.TinhGiaiThua(n));
            Console.ReadLine();
        }
    }
}