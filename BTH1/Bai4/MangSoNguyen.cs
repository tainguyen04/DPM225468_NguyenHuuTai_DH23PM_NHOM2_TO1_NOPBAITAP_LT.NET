using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class MangSoNguyen
    {
        public int NhapSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            return so;
        }
        public int NhapMotSo()
        {            
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void InMang(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}", a[i]);
            }
        }
        public int TimMax(int[] a) 
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++) 
            { 
                if(a[i] > max)
                    max = a[i];
            }
            return max;
        }
        public int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        public int TinhTong(int[] a)
        {
            int sum = 0;
            for(int i = 0;i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public void SapXep(int [] a)
        {
            for(int i = 0; i < a.Length-1; i++)
            {
                for(int j = 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}
