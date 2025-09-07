using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TimSLN
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public int TimMax(int n)
        {
            int max, i, temp;
            max = 0;
            i = 0;
            do
            {
                Console.Write("Nhập vào số thứ {0} = ", i + 1);
                temp = Convert.ToInt32(Console.ReadLine());
                if(max < temp)
                    max = temp;
                i++;
            }while (i < n);
            return max;
        }
    }
}
