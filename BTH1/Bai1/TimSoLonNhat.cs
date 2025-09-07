using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class TimSoLonNhat
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public int TimMax(int a, int b, int c)
        {
            int max;
            max = a > b ? a : b;
            max = max > c ? max : c;
            return max;
        }
    }
}
