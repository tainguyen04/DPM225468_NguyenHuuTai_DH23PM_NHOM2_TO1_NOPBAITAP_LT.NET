using System;
using System.Text;
namespace Bai8;
    public class PhuongTrinhBac2
    {
        // Thuộc tính (Hệ số của phương trình bậc hai)
        private int soa;
        private int sob;
        private int soc;

        // Các thuộc tính property
        public int Soa
        {
            get { return soa; }
            set { soa = value; }
        }

        public int Sob
        {
            get { return sob; }
            set { sob = value; }
        }

        public int Soc
        {
            get { return soc; }
            set { soc = value; }
        }

        // Phương thức khởi tạo không tham số
        public PhuongTrinhBac2()
        {
            soa = 1; // Giá trị mặc định cho a
            sob = 0; // Giá trị mặc định cho b
            soc = 0; // Giá trị mặc định cho c
        }

        // Phương thức khởi tạo ba tham số
        public PhuongTrinhBac2(int a, int b, int c)
        {
            soa = a;
            sob = b;
            soc = c;
        }

        // Phương thức tính nghiệm
        public void TinhNghiem()
        {
            double delta = sob * sob - 4 * soa * soc; // Tính delta

            // Kiểm tra các trường hợp của phương trình bậc hai
            if (delta > 0)
            {
                double nghiem1 = (-sob + Math.Sqrt(delta)) / (2 * soa);
                double nghiem2 = (-sob - Math.Sqrt(delta)) / (2 * soa);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}",nghiem1,nghiem2);
            }
            else if (delta == 0)
            {
                double nghiemKep = -sob / (2 * soa);
                Console.WriteLine("Phương trình có nghiệm kép: x = {0}",nghiemKep);
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }

        // Phương thức hiển thị kết quả
        public void HienThiKetQua()
        {
            Console.WriteLine("Phương trình: {0}x² + {1}x + {2} = 0",soa,sob,soc);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
            
            PhuongTrinhBac2 pt1 = new PhuongTrinhBac2(1, -3, 2);  
            pt1.HienThiKetQua();
            pt1.TinhNghiem();

            
            PhuongTrinhBac2 pt2 = new PhuongTrinhBac2();
            pt2.HienThiKetQua();
            pt2.TinhNghiem();
        }
    }