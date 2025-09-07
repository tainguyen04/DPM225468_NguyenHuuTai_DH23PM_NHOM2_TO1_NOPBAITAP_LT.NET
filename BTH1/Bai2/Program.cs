using Bai2;
using System.Text;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN timSLN = new TimSLN();
            int n;
            Console.Write("Nhập n = ");
            n = timSLN.NhapMotSo();
            Console.WriteLine("Số lớn nhất trong {0} số vừa nhập là {1}", n, timSLN.TimMax(n));
            Console.ReadLine();
        }
    }
}