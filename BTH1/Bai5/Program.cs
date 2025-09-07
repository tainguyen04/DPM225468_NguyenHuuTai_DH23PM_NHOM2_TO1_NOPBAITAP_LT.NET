using Bai5;
using System.Text;
namespace Bai5
{
    public class Student
    {
        private string _hoTen;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _dtb;

        public Student()
        {
            HoTen = "";
            DiemVan = 0;
            DiemToan = 0;
            Dtb = 0;
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public int Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }
        }
        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }
        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }
        public double Dtb
        {
            get { return Math.Round(((DiemToan + DiemVan) / 2), 2); }
            set { _dtb = value; }
        }
        public void nhap()
        {
            Console.Write(" \t -Nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.Write(" \t -Nhap diem toan:");
            Double temp;
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t !!! Diem phai nam trong khoang 0 -> 10");
                Console.Write(" \t -Nhap lai diem toan:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemToan = temp;
            Console.Write(" \t -Nhap diem van:");
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t -Diem phai nam trong khoang 0 -> 10");
                Console.Write(" \t -Nhap lai diem Van:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemVan = temp;
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", HoTen, DiemToan, DiemVan, Dtb);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" Nhap so luong hoc sinh: ");
            n = int.Parse(Console.ReadLine());
            Student[] _arrStudent = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Nhap thong tin sinh vien thu: " + (i + 1).ToString());
                _arrStudent[i] = new Student();
                _arrStudent[i].nhap();
            }
            Console.WriteLine(" Danh sach hoc sinh: ");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Ho Ten", "Diem Toan", "Diem Van", "DTB");
            for (int i = 0; i < n; i++)
            {
                _arrStudent[i].xuat();
            }
            Console.ReadLine();
        }
    }
}
   
