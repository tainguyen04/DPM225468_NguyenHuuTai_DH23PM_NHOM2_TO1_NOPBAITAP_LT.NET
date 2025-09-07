using System.Text;
namespace Bai6
{
    public class Emloyee
    {
        private int _id;
        private string _name;
        private int _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary;

        public Emloyee() { }
        public int GetId()
        {
            return _id;
        }
        public String GetName()
        {
            return _name;
        }
        public int GetYearOfBirth()
        {
            return _yearOfBirth;
        }
        public double GetInCome()
        {
            return _salaryLevel * _basicSalary;
        }
        public void SetSalaryLevel(double salaryLevel)
        {
            _salaryLevel = salaryLevel;
        }
        public void SetBaSicSalary(double baSicSalary)
        {
            _basicSalary = baSicSalary;
        }
        public void Input()
        {
            Console.Write("Nhập ID:");
            _id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên:");
            _name = Console.ReadLine();
            Console.Write("Nhập năm sinh:");
            _yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mức lương:");
            _salaryLevel = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("ID:{0} ", _id);
            Console.WriteLine("Tên:{0} ", _name);
            Console.WriteLine("Năm sinh:{0} ", _yearOfBirth);
            Console.WriteLine("Mức lương:{0} ", GetInCome());
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("Nhập lương cơ bản chung cho tất cả nhân viên: ");
                double basicSalary = Convert.ToDouble(Console.ReadLine());
                Emloyee emloyee = new Emloyee();
                emloyee.SetBaSicSalary(basicSalary);

                Console.Write("Nhập số lượng nhân viên: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Emloyee[] employees = new Emloyee[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nNhập thông tin cho nhân viên thứ {i + 1}:");
                    employees[i] = new Emloyee();
                    employees[i].Input();
                }

                Console.WriteLine("\n===== Danh sách nhân viên =====");
                foreach (var emp in employees)
                {
                    emp.Display();
                }
            }
        }
    }
}