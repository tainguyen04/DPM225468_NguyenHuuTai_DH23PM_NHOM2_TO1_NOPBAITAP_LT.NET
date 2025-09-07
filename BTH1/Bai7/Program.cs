using System;
using System.Text;
namespace Bai7;
    public class TamGiac
    {
    
        private int canh1;
        private int canh2;
        private int canh3;
        private float dienTich;
        private int chuVi;
        private string loaiTamGiac;

    
        public int Canh1
        {
            get { return canh1; }
            set { canh1 = value; }
        }

        public int Canh2
        {
            get { return canh2; }
            set { canh2 = value; }
        }

        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value; }
        }

        public float DienTich
        {
            get { return dienTich; }
        }

        public int ChuVi
        {
            get { return chuVi; }
        }

        public string LoaiTamGiac
        {
            get { return loaiTamGiac; }
        }

    
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = 5; 
            chuVi = TinhChuVi();
            dienTich = TinhDienTich();
            loaiTamGiac = XacDinhLoaiTamGiac();
        }

    
        public TamGiac(int a, int b, int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
            chuVi = TinhChuVi();
            dienTich = TinhDienTich();
            loaiTamGiac = XacDinhLoaiTamGiac();
        }

        
        public int TinhChuVi()
        {
            return canh1 + canh2 + canh3;
        }

        
        public float TinhDienTich()
        {
            float p = (float) chuVi / 2;
            return (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }

    
        public string XacDinhLoaiTamGiac()
        {
            if (canh1 == canh2 && canh2 == canh3)
                return "Tam giác đều";
            else if (canh1 == canh2 || canh1 == canh3 || canh2 == canh3)
                return "Tam giác vuông";
            else
                return "Tam giác thường";
        }

    
        public void HienThiThongTin()
        {
            Console.WriteLine("Cạnh 1: {0}",canh1);
            Console.WriteLine("Cạnh 2: {0}",canh2);
            Console.WriteLine("Cạnh 3: {0}",canh3);
            Console.WriteLine("Chu vi: {0}",chuVi);
            Console.WriteLine("Diện tích: {0}",dienTich);
            Console.WriteLine("Loại tam giác: {0}",loaiTamGiac);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TamGiac tamGiac1 = new TamGiac(3, 4, 5);
            tamGiac1.HienThiThongTin();

            TamGiac tamGiac2 = new TamGiac();
            tamGiac2.HienThiThongTin();
        }
    }